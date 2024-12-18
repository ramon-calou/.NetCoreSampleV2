using DotnetCore.Sample.DataContract.Abstractions;

namespace DotnetCore.Sample.DataContract.V1.Restaurants.GetRestaurants
{
	/// <summary>
	/// 
	/// </summary>
	public class GetRestaurantsRequest : BaseRequest
	{
		/// <summary>
		/// 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string OpenHour { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string CloseHour { get; set; }
	}
}