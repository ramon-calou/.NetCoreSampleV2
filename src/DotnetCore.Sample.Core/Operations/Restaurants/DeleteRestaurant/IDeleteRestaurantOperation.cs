using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.DataContract.V1.Restaurants.DeleteRestaurant;

namespace DotnetCore.Sample.Core.Operations.Restaurants.DeleteRestaurant
{
	/// <summary>
	/// 
	/// </summary>
	public interface IDeleteRestaurantOperation : IBaseOperation<DeleteRestaurantRequest, DeleteRestaurantResponse>
	{

	}
}