using Asp.Versioning;
using DotnetCore.Sample.Core.Jwt;
using DotnetCore.Sample.Core.Operations.Login;
using DotnetCore.Sample.Core.Repositories;
using DotnetCore.Sample.DataContract.V1.Login;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCore.Sample.Api.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiVersion("1")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly ITokenService _tokenService;

        public LoginController(IUnitOfWork unitOfWork, ITokenService tokenService)
        {
            _unitOfWork = unitOfWork;
            _tokenService = tokenService;
        }

        [HttpPost]
        public ActionResult Login([FromBody] LoginRequest contract)
        {
            var operation = new LoginOperation(_unitOfWork, _tokenService);

            var response = operation.Execute(contract);

            if (response.Success)
            {
                return this.Ok(response);
            }
            else
            {
                return this.BadRequest(response);
            }
        }
    }
}