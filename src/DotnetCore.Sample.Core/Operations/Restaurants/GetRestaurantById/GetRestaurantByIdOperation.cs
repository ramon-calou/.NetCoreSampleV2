using System;
using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.Core.Repositories;
using DotnetCore.Sample.DataContract.V1.Restaurants;
using DotnetCore.Sample.DataContract.V1.Restaurants.GetRestaurantById;

namespace DotnetCore.Sample.Core.Operations.Restaurants.GetRestaurantById
{
	/// <summary>
	/// 
	/// </summary>
	public class GetRestaurantByIdOperation : BaseOperation<GetRestaurantByIdRequest, GetRestaurantByIdResponse>, IGetRestaurantByIdOperation
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public GetRestaurantByIdOperation(IUnitOfWork unitOfWork)
			: base(unitOfWork)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		protected override GetRestaurantByIdResponse ProcessAsync(GetRestaurantByIdRequest request)
		{
			var restaurant = this.UnitOfWork.RestaurantRepository.GetById(Guid.Parse(request.RestaurantId));

			if(restaurant == null || !restaurant.IsActive)
			{
				return new GetRestaurantByIdResponse
				{
					ErrorMessage = "Restaurante não encontrado"
				};
			}

			return new GetRestaurantByIdResponse
			{
				Restaurant = new RestaurantResponseContract
				{
					Id = restaurant.Id,
					CloseHour = restaurant.CloseHour,
					OpenHour = restaurant.OpenHour,
					Name = restaurant.Name
				}
			};
		}

		/// <summary>
		/// 
		/// </summary>
		protected override bool ValidateAsync(GetRestaurantByIdRequest request)
		{
			if (!Guid.TryParse(request.RestaurantId, out _))
			{
				return false;
			}

			return true;
		}
	}
}