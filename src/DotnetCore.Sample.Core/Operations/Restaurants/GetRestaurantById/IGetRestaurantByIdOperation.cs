using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.DataContract.V1.Restaurants.GetRestaurantById;

namespace DotnetCore.Sample.Core.Operations.Restaurants.GetRestaurantById
{
	/// <summary>
	/// 
	/// </summary>
	public interface IGetRestaurantByIdOperation : IBaseOperation<GetRestaurantByIdRequest, GetRestaurantByIdResponse>
	{
	}
}