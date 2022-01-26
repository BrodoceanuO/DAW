using DAW2.Data;
using DAW2.Models;
using DAW2.Repository.DatabaseRepository.ThemeRepository;
using System.Collections.Generic;

namespace DAW2.Services.ThemeService
{
    public class ThemeService: IThemeService
    {
        public IThemeRepository _themeRepository;
        public DatabaseContext databaseContext;

        public ThemeService(IThemeRepository themeRepository)
        {
            _themeRepository = themeRepository;
        }

        public Theme GetDataMappedByThemeName(string SubscriptionName)
        {
            Theme theme = _themeRepository.GetByThemeName(SubscriptionName);
            return theme;

        }

        public List<Theme> GetAllThemes()
        {
            return _themeRepository.GetAll().Result;
        }

        public void UpdateTheme(Theme theme)
        {
            _themeRepository.Update(theme);
            _themeRepository.Save();
        }

        public void DeleteTheme(Theme theme)
        {
            _themeRepository.Delete(theme);
            _themeRepository.Save();
        }

        public void CreateTheme(Theme theme)
        {
            _themeRepository.Create(theme);
            _themeRepository.Save();
        }
    }
}
