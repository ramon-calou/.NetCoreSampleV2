using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using DotnetCore.Sample.Core.Entities.User;
using DotnetCore.Sample.Core.Extension;
using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.Core.Repositories;
using DotnetCore.Sample.DataContract.V1.User.CreateUser;

namespace DotnetCore.Sample.Core.Operations.User.CreateUser
{
    public class CreateUserOperation : BaseOperation<CreateUserRequest, CreateUserResponse>, ICreateUserOperation
    {
        public CreateUserOperation(IUnitOfWork unitOfWork)
        : base(unitOfWork)
        {
        }

        protected override CreateUserResponse ProcessAsync(CreateUserRequest request)
        {
            var bearerToken = request.BearerToken.Replace("Bearer ", string.Empty);
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(bearerToken);

            var claim = jwtToken?.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name);

            var user = new UserEntity
            {
                Email = request.RequestContract.Email,
                Password = Argon2Helper.GerarHashSenha(request.RequestContract.Password),
                Name = request.RequestContract.Name,
                CreatedBy = claim?.Value ?? string.Empty
            };

            this.UnitOfWork.UserRepository.InsertOne(user);

            return new CreateUserResponse()
            {
                CreatedUser = user.Id,
                Email = user.Email,
                Name = user.Name
            };
        }
    }
}