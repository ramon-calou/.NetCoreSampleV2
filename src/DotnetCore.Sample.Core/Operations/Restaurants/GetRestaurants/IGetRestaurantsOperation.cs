using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.DataContract.V1.Restaurants.GetRestaurants;

namespace DotnetCore.Sample.Core.Operations.Restaurants.GetRestaurants
{
	/// <summary>
	/// 
	/// </summary>
	public interface IGetRestaurantsOperation : IBaseOperation<GetRestaurantsRequest, GetRestaurantsResponse>
	{

	}
}