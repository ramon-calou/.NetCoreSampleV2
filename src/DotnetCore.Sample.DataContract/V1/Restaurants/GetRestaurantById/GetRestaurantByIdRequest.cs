using System;
using System.ComponentModel.DataAnnotations;
using DotnetCore.Sample.DataContract.Abstractions;
using DotnetCore.Sample.DataContract.Validations;

namespace DotnetCore.Sample.DataContract.V1.Restaurants.GetRestaurantById
{
	/// <summary>
	/// 
	/// </summary>
	public class GetRestaurantByIdRequest : BaseRequest
	{
		/// <summary>
		/// The Restaurant Id
		/// </summary>
		[Required]
		[GuidValidation(AllowEmptyGuid = false, ErrorMessage = "Please provide a valid GUID.")]
		public string RestaurantId { get; set; }
	}
}