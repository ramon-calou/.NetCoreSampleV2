using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCore.Sample.Core.Jwt
{
    public interface ITokenService
    {
         string GenerateToken(string email);
    }
}