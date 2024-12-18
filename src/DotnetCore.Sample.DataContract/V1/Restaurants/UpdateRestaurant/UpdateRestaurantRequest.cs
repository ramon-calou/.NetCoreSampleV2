using DotnetCore.Sample.DataContract.Abstractions;
using DotnetCore.Sample.DataContract.Validations;

namespace DotnetCore.Sample.DataContract.V1.Restaurants.UpdateRestaurant
{
	/// <summary>
	/// 
	/// </summary>
	public class UpdateRestaurantRequest : BaseRequest
	{
		/// <summary>
		/// 
		/// </summary>
		[GuidValidation(AllowEmptyGuid = false, ErrorMessage = "Please provide a valid GUID.")]
		public string RestaurantId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public RestaurantContract RestaurantContract { get; set; }
	}
}