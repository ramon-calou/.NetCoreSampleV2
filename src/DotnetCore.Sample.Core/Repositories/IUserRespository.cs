using DotnetCore.Sample.Core.Entities.User;
using MongoDbGenericRepository;

namespace DotnetCore.Sample.Core.Repositories
{
    public interface IUserRespository : IBaseMongoRepository
    {
        /// <summary>
		/// Get <see cref="UserEntity" /> by Email
        /// </summary>
        UserEntity GetByEmail (string email);

        /// <summary>
		/// Insert <see cref="UserEntity" />
        /// </summary>
        void InsertOne(UserEntity user);
    }
}