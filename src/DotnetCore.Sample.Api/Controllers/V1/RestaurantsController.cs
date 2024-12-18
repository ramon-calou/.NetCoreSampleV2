using DotnetCore.Sample.Core.Operations.Restaurants.GetRestaurant;
using DotnetCore.Sample.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using DotnetCore.Sample.DataContract.V1.Restaurants.GetRestaurants;

namespace DotnetCore.Sample.Api.Controllers.V1
{
	[Route("api/[controller]")]
	[ApiController]
	public class RestaurantsController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;

		public RestaurantsController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		[Route("{restaurantId}")]
		[HttpGet]
		public ActionResult Get([FromRoute] string restaurantId)
		{
			var request = new GetRestaurantRequest()
			{
				RestaurantId = restaurantId
			};

			var operation = new GetRestaurantOperation(_unitOfWork);

			var response = operation.Execute(request);

			if (response.Success)
			{
				return this.Ok(response);
			}
			else
			{
				return this.BadRequest(response);
			}
		}

		// [HttpGet("{id:length(24)}", Name = "GetRestaurant")]
		// [ProducesResponseType(StatusCodes.Status404NotFound)]
		// public ActionResult<Restaurant> Get(string id)
		// {
		// 	var restaurant = _restaurantService.Get(id);

		// 	if (restaurant == null)
		// 	{
		// 		return NotFound();
		// 	}

		// 	return restaurant;
		// }

		// [HttpGet("{time:length(4)}", Name = "GetRestaurantByTime")]
		// [ProducesResponseType(StatusCodes.Status404NotFound)]
		// public ActionResult<List<Restaurant>> GetByTime(string time)
		// {
		// 	var restaurant = _restaurantService.GetByTime(time);

		// 	if (restaurant == null)
		// 	{
		// 		return NotFound();
		// 	}

		// 	return restaurant;
		// }

		// [HttpPost]
		// [ProducesResponseType(StatusCodes.Status201Created)]
		// [ProducesResponseType(StatusCodes.Status400BadRequest)]
		// public ActionResult<Restaurant> Create(Restaurant restaurant)
		// {
		//     _restaurantService.Create(restaurant);

		//     return CreatedAtRoute("GetRestaurant", new { id = restaurant.Id.ToString() }, restaurant);
		// }

		// [HttpPost]
		// [ProducesResponseType(StatusCodes.Status201Created)]
		// [ProducesResponseType(StatusCodes.Status400BadRequest)]
		// public ActionResult CreateMany(List<Restaurant> restaurants)
		// {

		// 	var result = _restaurantService.CreatMany(restaurants);

		// 	if (result != null)
		// 	{
		// 		return StatusCode(201);
		// 	}

		// 	return StatusCode(400);
		// }

		// [HttpPut("{id:length(24)}")]
		// public IActionResult Update(string id, Restaurant restaurantIn)
		// {
		// 	var restaurant = _restaurantService.Get(id);

		// 	if (restaurant == null)
		// 	{
		// 		return NotFound();
		// 	}

		// 	_restaurantService.Update(id, restaurantIn);

		// 	return NoContent();
		// }

		// [HttpDelete("{id:length(24)}")]
		// public IActionResult Delete(string id)
		// {
		// 	var restaurant = _restaurantService.Get(id);

		// 	if (restaurant == null)
		// 	{
		// 		return NotFound();
		// 	}

		// 	_restaurantService.Remove(restaurant.Id);

		// 	return NoContent();
		// }
	}
}