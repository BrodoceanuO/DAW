using DAW2.Models.Base;
using System;

namespace DAW2.Models
{
    public class Theme : BaseEntity
    {
        public string ThemeName { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}
