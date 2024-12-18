using DotnetCore.Sample.DataContract.Abstractions;
using DotnetCore.Sample.DataContract.Validations;

namespace DotnetCore.Sample.DataContract.V1.Restaurants.DeleteRestaurant
{
	/// <summary>
	/// 
	/// </summary>
	public class DeleteRestaurantRequest : BaseRequest
	{
		/// <summary>
		/// 
		/// </summary>
		[GuidValidation(AllowEmptyGuid = false, ErrorMessage = "Please provide a valid GUID.")]
		public string RestaurantId { get; set; }
	}
}