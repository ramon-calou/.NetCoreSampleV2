using DotnetCore.Sample.Core.Entities.User;
using DotnetCore.Sample.Core.Repositories;
using MongoDB.Driver;
using MongoDbGenericRepository;

namespace DotnetCore.Sample.Repository.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public class UserRepository : BaseMongoRepository, IUserRespository
    {
        /// <summary>
		/// 
		/// </summary>
		private readonly IMongoCollection<UserEntity> _userCollection;

        /// <summary>
        /// Default constructor
        /// </summary>
        public UserRepository(IMongoDatabase mongoDatabase) : base(mongoDatabase)
        {
			_userCollection = this.MongoDbContext.Database.GetCollection<UserEntity>("User");
        }

        public UserEntity GetByEmail(string email)
        {
            var filter = Builders<UserEntity>.Filter.Eq(x => x.Email, email);

            return _userCollection.Find(filter).FirstOrDefault();
        }
    }
}