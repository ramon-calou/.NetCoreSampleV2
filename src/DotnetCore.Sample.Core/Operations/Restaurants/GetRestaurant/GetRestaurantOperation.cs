using System;
using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.Core.Repositories;
using DotnetCore.Sample.DataContract.V1.Restaurants;
using DotnetCore.Sample.DataContract.V1.Restaurants.GetRestaurants;

namespace DotnetCore.Sample.Core.Operations.Restaurants.GetRestaurant
{
	/// <summary>
	/// 
	/// </summary>
	public class GetRestaurantOperation : BaseOperation<GetRestaurantRequest, GetRestaurantResponse>, IGetRestaurantOperation
	{
		/// <summary>
		/// Default constructor
		/// </summary>
		public GetRestaurantOperation(IUnitOfWork unitOfWork)
			: base(unitOfWork)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		protected override GetRestaurantResponse ProcessAsync(GetRestaurantRequest request)
		{
			var restaurant = this.UnitOfWork.RestaurantRepository.GetById(Guid.Parse(request.RestaurantId));

			return new GetRestaurantResponse
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
		protected override bool ValidateAsync(GetRestaurantRequest request)
		{
			if (!Guid.TryParse(request.RestaurantId, out _))
			{
				return false;
			}

			return true;
		}
	}
}