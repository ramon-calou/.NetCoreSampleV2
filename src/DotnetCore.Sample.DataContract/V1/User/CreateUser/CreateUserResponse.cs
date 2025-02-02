using DotnetCore.Sample.DataContract.Abstractions;

namespace DotnetCore.Sample.DataContract.V1.User.CreateUser
{
    public class CreateUserResponse : BaseResponse
    {
        public Guid CreatedUser { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}