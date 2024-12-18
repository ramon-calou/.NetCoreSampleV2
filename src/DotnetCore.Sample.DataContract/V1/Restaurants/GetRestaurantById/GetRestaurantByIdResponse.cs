using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetCore.Sample.DataContract.Abstractions;

namespace DotnetCore.Sample.DataContract.V1.Restaurants.GetRestaurantById
{
	/// <summary>
	/// 
	/// </summary>
	public class GetRestaurantByIdResponse : BaseResponse
	{
		/// <summary>
		/// 
		/// </summary>
		public RestaurantResponseContract Restaurant { get; set; }
	}
}