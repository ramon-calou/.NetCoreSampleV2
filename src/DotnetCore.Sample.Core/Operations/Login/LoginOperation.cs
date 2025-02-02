using DotnetCore.Sample.Core.Entities.User;
using DotnetCore.Sample.Core.Extension;
using DotnetCore.Sample.Core.Jwt;
using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.Core.Repositories;
using DotnetCore.Sample.DataContract.Abstractions;
using DotnetCore.Sample.DataContract.V1.Login;

namespace DotnetCore.Sample.Core.Operations.Login
{
    public class LoginOperation : BaseOperation<LoginRequest, LoginResponse>, ILoginOperation
    {
        /// <summary>
        /// 
        /// </summary>
        private UserEntity FoundUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private ITokenService TokenService;

        /// <summary>
        /// 
        /// </summary>
        public LoginOperation(IUnitOfWork unitOfWork, ITokenService tokenService)
        : base(unitOfWork)
        {
            this.TokenService = tokenService;
        }

        /// <summary>
        /// 
        /// </summary>
        protected override LoginResponse ProcessAsync(LoginRequest request)
        {
            var generatedToken = this.TokenService.GenerateToken(request.Email);
            return new LoginResponse
            {
                Token = generatedToken
            };
        }

        protected override BaseResponse ValidateAsync(LoginRequest request)
        {
            var response = new BaseResponse();

            this.FoundUser = this.UnitOfWork.UserRepository.GetByEmail(request.Email);

            if (this.FoundUser == null || !Argon2Helper.VerificarSenha(request.Password, this.FoundUser.Password))
            {
                response.ErrorMessage = "Wrong Email or Password. Please check";
            }

            return response;
        }
    }
}