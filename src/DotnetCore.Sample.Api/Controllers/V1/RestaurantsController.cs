using DotnetCore.Sample.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using DotnetCore.Sample.DataContract.V1.Restaurants.GetRestaurants;
using DotnetCore.Sample.DataContract.V1.Restaurants;
using DotnetCore.Sample.DataContract.V1.Restaurants.CreateRestaurant;
using DotnetCore.Sample.Core.Operations.Restaurants.CreateRestaurant;
using DotnetCore.Sample.DataContract.V1.Restaurants.UpdateRestaurant;
using DotnetCore.Sample.Core.Operations.Restaurants.UpdateRestaurant;
using DotnetCore.Sample.DataContract.V1.Restaurants.DeleteRestaurant;
using DotnetCore.Sample.Core.Operations.Restaurants.DeleteRestaurant;
using DotnetCore.Sample.DataContract.V1.Restaurants.GetRestaurantById;
using DotnetCore.Sample.Core.Operations.Restaurants.GetRestaurantById;
using DotnetCore.Sample.Core.Operations.Restaurants.GetRestaurants;
using Microsoft.AspNetCore.Authorization;
using Asp.Versioning;

namespace DotnetCore.Sample.Api.Controllers.V1
{
	[Route("api/[controller]")]
    [ApiVersion("1")]
	[ApiController]
	[Authorize]
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
			var request = new GetRestaurantByIdRequest()
			{
				RestaurantId = restaurantId
			};

			var operation = new GetRestaurantByIdOperation(_unitOfWork);

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

		[HttpGet()]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public ActionResult GetByFilters(
			[FromQuery] string openHour,
			[FromQuery] string closeHour,
			[FromQuery] string name)
		{
			var request = new GetRestaurantsRequest()
			{
				CloseHour = closeHour,
				Name = name,
				OpenHour = openHour
			};

			var operation = new GetRestaurantsOperation(_unitOfWork);

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

		[HttpPost]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public ActionResult Create([FromBody] RestaurantContract contract)
		{
			var request = new CreateRestaurantRequest()
			{
				RestaurantContract = contract
			};

			var operation = new CreateRestaurantOperation(_unitOfWork);

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

		[HttpPut]
		[Route("{restaurantId}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public ActionResult Update([FromRoute] string restaurantId, [FromBody] RestaurantContract contract)
		{
			var request = new UpdateRestaurantRequest()
			{
				RestaurantId = restaurantId,
				RestaurantContract = contract
			};

			var operation = new UpdateRestaurantOperation(_unitOfWork);

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

		[HttpDelete]
		[Route("Deactive/{restaurantId}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public ActionResult Delete([FromRoute] string restaurantId)
		{
			var request = new DeleteRestaurantRequest()
			{
				RestaurantId = restaurantId
			};

			var operation = new DeleteRestaurantOperation(_unitOfWork);

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
	}
}