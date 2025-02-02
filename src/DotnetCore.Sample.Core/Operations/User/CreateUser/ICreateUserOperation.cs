using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.DataContract.V1.User.CreateUser;

namespace DotnetCore.Sample.Core.Operations.User.CreateUser
{
    public interface ICreateUserOperation : IBaseOperation<CreateUserRequest, CreateUserResponse>
    {
        
    }
}