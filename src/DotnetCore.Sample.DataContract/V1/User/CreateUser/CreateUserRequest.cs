using DotnetCore.Sample.DataContract.Abstractions;

namespace DotnetCore.Sample.DataContract.V1.User.CreateUser
{
    public class CreateUserRequest : BaseRequest
    {
        public CreateUserRequestContract RequestContract { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BearerToken { get; set; }
    }
}