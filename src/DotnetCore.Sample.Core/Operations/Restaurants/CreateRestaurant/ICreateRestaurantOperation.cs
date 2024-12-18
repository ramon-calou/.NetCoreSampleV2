using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.DataContract.V1.Restaurants.CreateRestaurant;

namespace DotnetCore.Sample.Core.Operations.Restaurants.CreateRestaurant
{
	/// <summary>
	/// 
	/// </summary>
	public interface ICreateRestaurantOperation : IBaseOperation<CreateRestaurantRequest, CreateRestaurantResponse>
	{

	}
}