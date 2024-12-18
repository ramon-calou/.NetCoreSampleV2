using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetCore.Sample.DataContract.Abstractions;

namespace DotnetCore.Sample.DataContract.V1.Restaurants.GetRestaurants
{
	/// <summary>
	/// 
	/// </summary>
	public class GetRestaurantResponse : BaseResponse
	{
		public RestaurantResponseContract Restaurant { get; set; }
	}
}