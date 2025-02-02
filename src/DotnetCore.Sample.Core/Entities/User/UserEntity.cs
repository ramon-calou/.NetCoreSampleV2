using DotnetCore.Sample.Core.Entities.Abstraction;

namespace DotnetCore.Sample.Core.Entities.User
{
    /// <summary>
    /// 
    /// </summary>
    public class UserEntity : BaseEntity
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }
    }
}