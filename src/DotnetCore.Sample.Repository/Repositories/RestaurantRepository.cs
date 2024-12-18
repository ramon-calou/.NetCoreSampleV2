using System;
using System.Collections.Generic;
using System.Linq;
using DotnetCore.Sample.Core.Entities.Restaurant;
using DotnetCore.Sample.Core.Repositories;
using MongoDB.Driver;
using MongoDbGenericRepository;

namespace DotnetCore.Sample.Repository.Repositories
{
	/// <summary>
	/// 
	/// </summary>
	public class RestaurantRepository : BaseMongoRepository, IRestaurantRepository
	{
		/// <summary>
		/// 
		/// </summary>
		private readonly IMongoCollection<RestaurantEntity> _restaurantCollection;

		/// <summary>
		/// 
		/// </summary>
		public RestaurantRepository(IMongoDatabase mongoDatabase)
			: base(mongoDatabase)
		{
			_restaurantCollection = this.MongoDbContext.Database.GetCollection<RestaurantEntity>("Restaurant");
		}

		/// <summary>
		/// 
		/// </summary>
		public RestaurantEntity Deactivate(RestaurantEntity restaurant)
		{
			var updateDefinition = Builders<RestaurantEntity>.Update
				.Set(x => x.IsActive, false);

			_restaurantCollection.UpdateOne(x => x.Id == restaurant.Id, updateDefinition);

			return restaurant;
		}

		/// <summary>
		/// 
		/// </summary>
		public List<RestaurantEntity> GetByFilters(FilterDefinition<RestaurantEntity> filter)
			=> _restaurantCollection
				.Find(filter)
				.ToList();

		/// <summary>
		/// 
		/// </summary>
		public RestaurantEntity GetById(Guid id)
			=> _restaurantCollection
				.Find(x => x.Id == id)
				.FirstOrDefault();

		/// <summary>
		/// 
		/// </summary>
		public RestaurantEntity Insert(RestaurantEntity restaurant)
		{
			_restaurantCollection
				.InsertOne(restaurant);
			return restaurant;
		}

		/// <summary>
		/// 
		/// </summary>
		public RestaurantEntity Update(RestaurantEntity restaurantEntity)
		{
			var filter = Builders<RestaurantEntity>.Filter.Eq(x => x.Id, restaurantEntity.Id);

			_restaurantCollection.ReplaceOne(filter, restaurantEntity);
			return restaurantEntity;
		}
	}
}