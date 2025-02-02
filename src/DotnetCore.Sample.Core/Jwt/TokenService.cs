using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DotnetCore.Sample.Core.Settings;
using Microsoft.IdentityModel.Tokens;

namespace DotnetCore.Sample.Core.Jwt
{
    /// <summary>
    /// 
    /// </summary>
    public class TokenService : ITokenService
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IJwtSettings _jwtSettings;

        /// <summary>
        /// 
        /// </summary>
        public TokenService(IJwtSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        /// <summary>
        /// 
        /// </summary>
        public string GenerateToken(string email)
        {
            var claims = new[]
            {
            new Claim(ClaimTypes.Name, email),
            new Claim(JwtRegisteredClaimNames.Sub, email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(_jwtSettings.ExpirationInMinutes),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}