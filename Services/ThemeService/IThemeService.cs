using DAW2.Models;
using System.Collections.Generic;

namespace DAW2.Services.ThemeService
{
    public interface IThemeService
    {
        Theme GetDataMappedByThemeName(string ThemeName);

        //GET
        List<Theme> GetAllThemes();

        //UPDATE
        void UpdateTheme(Theme theme);

        //DELETE
        void DeleteTheme(Theme theme);

        //CREATE
        void CreateTheme(Theme theme);
    }
}
