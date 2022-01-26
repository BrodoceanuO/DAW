using DAW2.Models;
using DAW2.Repository.GenericRepository;

namespace DAW2.Repository.DatabaseRepository.ThemeRepository
{
    public interface IThemeRepository : IGenericRepository<Theme>
    {
        Theme GetByThemeName(string ThemeName);
    }
}
