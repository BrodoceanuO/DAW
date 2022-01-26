using DAW2.Models;
using System;

namespace DAW2.Utilities.JWTUtils
{
    public interface IJWTUtils
    {
        public string GenerateJWTToken(User user);
        public Guid ValidateJWTToken(string token);
    }
}
