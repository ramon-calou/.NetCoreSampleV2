using Microsoft.Extensions.Configuration;

namespace DotnetCore.Sample.Core.Settings
{
    public class JwtSettings : IJwtSettings
    {
        public string SecretKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpirationInMinutes { get; set; }
    }
}