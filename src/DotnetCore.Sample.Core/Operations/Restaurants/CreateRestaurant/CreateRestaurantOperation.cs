using System;
using DotnetCore.Sample.Core.Entities.Restaurant;
using DotnetCore.Sample.Core.Operations.Abstractions;
using DotnetCore.Sample.Core.Repositories;
using DotnetCore.Sample.DataContract.V1.Restaurants;
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
		public CreateRestaurantOperation(IUnitOfWork unitOfWork)
		: base(unitOfWork)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		protected override CreateRestaurantResponse ProcessAsync(CreateRestaurantRequest request)
		{
			var restaurant = new RestaurantEntity
			{
				Name = request.RestaurantContract.Name,
				OpenHour = request.RestaurantContract.OpenHour,
				CloseHour = request.RestaurantContract.CloseHour
			};

			var insertedRestaurant = this.UnitOfWork.RestaurantRepository.Insert(restaurant);

			return new CreateRestaurantResponse
			{
				Restaurant = new RestaurantResponseContract
				{
					CloseHour = insertedRestaurant.CloseHour,
					OpenHour = insertedRestaurant.OpenHour,
					Name = insertedRestaurant.Name,
					Id = insertedRestaurant.Id
				}
			};
		}
	}
}