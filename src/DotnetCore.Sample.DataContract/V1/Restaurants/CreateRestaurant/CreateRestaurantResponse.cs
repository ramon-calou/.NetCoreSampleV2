using DotnetCore.Sample.DataContract.Abstractions;

namespace DotnetCore.Sample.DataContract.V1.Restaurants.CreateRestaurant
{
    /// <summary>
    /// 
    /// </summary>
	public class CreateRestaurantResponse : BaseResponse
	{
        /// <summary>
        /// 
        /// </summary>
		public RestaurantResponseContract Restaurant { get; set; }
	}
}