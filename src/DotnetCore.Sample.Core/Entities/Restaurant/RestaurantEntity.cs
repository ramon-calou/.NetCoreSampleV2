using DotnetCore.Sample.Core.Entities.Abstraction;
using MongoDB.Bson.Serialization.Attributes;

namespace DotnetCore.Sample.Core.Entities.Restaurant
{
	/// <summary>
	/// 
	/// </summary>
	[BsonIgnoreExtraElements]
	public class RestaurantEntity : BaseEntity
	{
		/// <summary>
		/// 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int OpenHour { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public int CloseHour { get; set; }
	}
}