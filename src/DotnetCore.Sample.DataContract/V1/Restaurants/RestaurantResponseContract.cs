using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCore.Sample.DataContract.V1.Restaurants
{
    /// <summary>
    /// 
    /// </summary>
	public class RestaurantResponseContract
	{
		/// <summary>
		/// The restaurant Id
		/// </summary>
		public Guid Id { get; set; }

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