using System;
using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.Core.Repositories;
using DotnetCore.Sample.DataContract.V1.Restaurants.CreateRestaurant;

namespace DotnetCore.Sample.Core.Operations.Restaurants.CreateRestaurant
{
	/// <summary>
	/// 
	/// </summary>
	public class CreateRestaurantOperation : BaseOperation<CreateRestaurantRequest, CreateRestaurantResponse>, ICreateRestaurantOperation
	{
		/// <summary>
		/// 
		/// </summary>
		public CreateRestaurantOperation(IUnitOfWork unitOfWork) : base(unitOfWork)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		protected override CreateRestaurantResponse ProcessAsync(CreateRestaurantRequest request)
		{
			throw new NotImplementedException();
		}
	}
}