using DotnetCore.Sample.Core.Entities.Abstraction;
using MongoDB.Bson.Serialization.Attributes;
using MongoDbGenericRepository.Attributes;

namespace DotnetCore.Sample.Core.Entities.User
{
    /// <summary>
    /// 
    /// </summary>
	[CollectionName("User")]
    [BsonIgnoreExtraElements]
    public class UserEntity : BaseEntity
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string CreatedBy { get; set; }
    }
}