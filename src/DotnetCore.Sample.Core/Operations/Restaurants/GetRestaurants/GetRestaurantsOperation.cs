using System;
using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.Core.Repositories;
using DotnetCore.Sample.DataContract.V1.Restaurants.GetRestaurants;

namespace DotnetCore.Sample.Core.Operations.Restaurants.GetRestaurants
{
	/// <summary>
	/// 
	/// </summary>
	public class GetRestaurantsOperation : BaseOperation<GetRestaurantsRequest, GetRestaurantsResponse>, IGetRestaurantsOperation
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public GetRestaurantsOperation(IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		protected override GetRestaurantsResponse ProcessAsync(GetRestaurantsRequest request)
		{
			throw new NotImplementedException();
		}
	}
}