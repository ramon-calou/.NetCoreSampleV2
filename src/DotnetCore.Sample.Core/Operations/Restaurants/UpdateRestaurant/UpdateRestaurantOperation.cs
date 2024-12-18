using System;
using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.Core.Repositories;
using DotnetCore.Sample.DataContract.V1.Restaurants.UpdateRestaurant;

namespace DotnetCore.Sample.Core.Operations.Restaurants.UpdateRestaurant
{
	/// <summary>
	/// 
	/// </summary>
	public class UpdateRestaurantOperation : BaseOperation<UpdateRestaurantRequest, UpdateRestaurantResponse>, IUpdateRestaurantOperation
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public UpdateRestaurantOperation(IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		protected override UpdateRestaurantResponse ProcessAsync(UpdateRestaurantRequest request)
		{
			throw new NotImplementedException();
		}
	}
}