using System;
using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.Core.Repositories;
using DotnetCore.Sample.DataContract.V1.Restaurants.DeleteRestaurant;

namespace DotnetCore.Sample.Core.Operations.Restaurants.DeleteRestaurant
{
	/// <summary>
	/// 
	/// </summary>
	public class DeleteRestaurantOperation : BaseOperation<DeleteRestaurantRequest, DeleteRestaurantResponse>, IDeleteRestaurantOperation
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public DeleteRestaurantOperation(IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		protected override DeleteRestaurantResponse ProcessAsync(DeleteRestaurantRequest request)
		{
			throw new NotImplementedException();
		}
	}
}