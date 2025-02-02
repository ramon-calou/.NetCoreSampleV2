namespace DotnetCore.Sample.Core.Settings
{
    public interface IJwtSettings
    {
        string SecretKey { get; }
        string Issuer { get; }
        string Audience { get; }
        int ExpirationInMinutes { get; }
    }
}