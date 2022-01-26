using DAW2.Data;
using DAW2.Models;
using DAW2.Repository.GenericRepository;
using System.Linq;

namespace DAW2.Repository.DatabaseRepository.ThemeRepository
{
    public class ThemeRepository : GenericRepository<Theme>, IThemeRepository
    {
        public ThemeRepository(DatabaseContext context) : base(context)
        {

        }

        public Theme GetByThemeName(string ThemeName)
        {
            return _table.FirstOrDefault(x => x.ThemeName.ToLower().Equals(ThemeName.ToLower()));
        }
    }
}
