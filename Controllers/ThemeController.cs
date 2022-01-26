using DAW2.Data;
using DAW2.Models;
using DAW2.Services.ThemeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DAW2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThemeController : ControllerBase
    {
        private readonly DatabaseContext _databaseContext;

        private readonly IThemeService _themeService;

        /*
        public ThemeController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        */

        public ThemeController(IThemeService themeService)
        {
            _themeService = themeService;
        }

        //GET
        [HttpGet]
        public IActionResult GetAllThemes()
        {
            var themes = _themeService.GetAllThemes();
            return Ok(themes);
        }


        //PUT
        [HttpPut("UpdateTheme")]
        public IActionResult Update(Theme theme)
        {
            _themeService.UpdateTheme(theme);
            return Ok();
        }

        //DELETE
        [HttpDelete("DeleteTheme")]
        public IActionResult Delete(Theme theme)
        {
            _themeService.DeleteTheme(theme);
            return Ok();
        }

        //CREATE
        [HttpPost("CreateTheme")]
        public IActionResult Create(Theme theme)
        {
            _themeService.CreateTheme(theme);
            return Ok();
        }
    }
}
