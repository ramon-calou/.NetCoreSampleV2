using System;
using System.Collections.Generic;
using DotnetCore.Sample.Core.Entities.Restaurant;
using MongoDB.Driver;
using MongoDbGenericRepository;

namespace DotnetCore.Sample.Core.Repositories
{
	/// <summary>
	/// 
	/// </summary>
	public interface IRestaurantRepository : IBaseMongoRepository
	{
		// /// <summary>
		// /// Get <see cref="RestaurantEntity" /> by Id
		// /// </summary>
		// RestaurantEntity GetById(Guid id);

		// /// <summary>
		// /// Get <see cref="RestaurantEntity" /> by Id
		// /// </summary>
		// List<RestaurantEntity> GetByFilters(FilterDefinition<RestaurantEntity> filter);

		// /// <summary>
		// /// Insert a <see cref="RestaurantEntity" /> on Database
		// /// </summary>
		// RestaurantEntity Insert(RestaurantEntity restaurant);

        // /// <summary>
        // /// 
        // /// </summary>
		// RestaurantEntity Update(RestaurantEntity restaurantEntity);

        /// <summary>
        /// 
        /// </summary>
		RestaurantEntity Deactivate(RestaurantEntity restaurant);
	}
}