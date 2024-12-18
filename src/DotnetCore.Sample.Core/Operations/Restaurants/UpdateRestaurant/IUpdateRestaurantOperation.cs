using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.DataContract.V1.Restaurants.UpdateRestaurant;

namespace DotnetCore.Sample.Core.Operations.Restaurants.UpdateRestaurant
{
	/// <summary>
	/// 
	/// </summary>
	public interface IUpdateRestaurantOperation : IBaseOperation<UpdateRestaurantRequest, UpdateRestaurantResponse>
	{
	}
}