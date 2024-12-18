using System.ComponentModel.DataAnnotations;
using DotnetCore.Sample.DataContract.Abstractions;

namespace DotnetCore.Sample.DataContract.V1.Restaurants.CreateRestaurant
{
    /// <summary>
    /// 
    /// </summary>
	public class CreateRestaurantRequest : BaseRequest
	{
        /// <summary>
        /// 
        /// </summary>
        [Required]
		public RestaurantContract RestaurantContract { get; set; }
	}
}