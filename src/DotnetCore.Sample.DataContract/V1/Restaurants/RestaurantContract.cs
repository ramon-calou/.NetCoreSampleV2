using System.ComponentModel.DataAnnotations;

namespace DotnetCore.Sample.DataContract.V1.Restaurants
{
	/// <summary>
	/// 
	/// </summary>
	public class RestaurantContract
	{
		/// <summary>
		/// 
		/// </summary>
		[Required]
		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Required]
		public int OpenHour { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Required]
		public int CloseHour { get; set; }
	}
}