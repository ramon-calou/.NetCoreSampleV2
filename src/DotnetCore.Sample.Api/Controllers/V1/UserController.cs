using Asp.Versioning;
using DotnetCore.Sample.Core.Operations.User.CreateUser;
using DotnetCore.Sample.Core.Repositories;
using DotnetCore.Sample.DataContract.V1.User.CreateUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCore.Sample.Api.Controllers.V1
{
	[Route("api/[controller]")]
	[ApiVersion("1")]
	[ApiController]
	[Authorize]
	public class UserController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;

		public UserController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		[HttpPost]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public ActionResult Create([FromBody] CreateUserRequestContract contract)
		{
			var bearerToken = this.HttpContext.Request.Headers.Authorization;

			var request = new CreateUserRequest()
			{
				RequestContract = contract,
				BearerToken = bearerToken
			};

			var operation = new CreateUserOperation(_unitOfWork);

			var response = operation.Execute(request);

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