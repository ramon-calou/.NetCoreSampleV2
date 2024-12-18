using DotnetCore.Sample.DataContract.Abstractions;

namespace DotnetCore.Sample.DataContract.V1.Restaurants.UpdateRestaurant
{
	/// <summary>
	/// 
	/// </summary>
	public class UpdateRestaurantResponse : BaseResponse
	{
		/// <summary>
		/// 
		/// </summary>
		RestaurantResponseContract Restaurant { get; set; }
	}
}