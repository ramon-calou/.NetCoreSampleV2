
using System.Diagnostics.CodeAnalysis;
using DotnetCore.Sample.DataContract.Abstractions;

namespace DotnetCore.Sample.DataContract.V1.Login
{
    public class LoginRequest : BaseRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}