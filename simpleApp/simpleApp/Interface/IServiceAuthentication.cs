using System;

namespace simpleApp.Interface
{
    public interface IServiceAuthentication
    {
        string GenerateToken(string issuer, string audience, TimeSpan expirationMinutes);
    }
}
