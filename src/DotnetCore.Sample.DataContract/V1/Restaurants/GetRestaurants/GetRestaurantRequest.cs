using System;
using System.ComponentModel.DataAnnotations;
using DotnetCore.Sample.DataContract.Abstractions;

namespace DotnetCore.Sample.DataContract.V1.Restaurants.GetRestaurants
{
	/// <summary>
	/// 
	/// </summary>
	public class GetRestaurantRequest : BaseRequest
	{
		/// <summary>
		/// The Restaurant Id
		/// </summary>
		[Required]
		public string RestaurantId { get; set; }
	}
}