using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.DataContract.V1.Restaurants.GetRestaurants;

namespace DotnetCore.Sample.Core.Operations.Restaurants.GetRestaurant
{
    /// <summary>
    /// 
    /// </summary>
	public interface IGetRestaurantOperation : IBaseOperation<GetRestaurantRequest, GetRestaurantResponse>
	{
	}
}