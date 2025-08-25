using Application.Models;
using Application.UseCase.Guest.GetGuestsList.Models;
using Application.UseCase.Place.AddPlace;
using Application.UseCase.Place.AddPlace.Models;
using Festify.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace Festify.Controllers.Authorized;

public class PlaceController : BaseAuthController
{
    /// <summary>
    /// Создать площадку для мероприятия
    /// </summary>
    /// <returns></returns>
    [HttpPost()]
    [ProducesResponseType(typeof(BaseApiResponseModel<long>), 200)]
    public async Task<IActionResult> CreatePlace([FromServices] CreatePlaceUseCase useCase, [FromBody] CreatePlaceRequest request)
    {
        var result = await useCase.CreatePlace(request);
        return FromResult(result);
    }
    //[HttpGet("{id:long}")]
    //[ProducesResponseType(typeof(BaseApiResponseModel<PlaceDto>), 200)]
    //public async Task<IActionResult> GetPlaceById(long id)
    //{
    //    var result = await Mediator.Send(new GetPlaceByGuestIdQuery(id));
    //    return FromResult(result);
    //}

    //[HttpGet("get-current-place")]
    //[ProducesResponseType(typeof(BaseApiResponseModel<PlaceDto>), 200)]
    //public async Task<IActionResult> GetPlaceByGuestId(long id)
    //{
    //    var result = await Mediator.Send(new GetPlaceByGuestIdQuery(id));
    //    return FromResult(result);
    //}

    //[HttpGet("get-place-list")]
    //[ProducesResponseType(typeof(BaseApiResponseModel<List<PlaceDto>>), 200)]
    //public async Task<IActionResult> GetPlaceList()
    //{
    //    var result = await Mediator.Send(new GetPlacesListQuery());
    //    return FromResult(result);
    //}

    //[HttpPost("add-place")]
    //[ProducesResponseType(typeof(ApiResponseModel), 200)]
    //public async Task<IActionResult> AddPlace(AddPlaceCommand request)
    //{
    //    var result = await Mediator.Send(request);
    //    return FromResult(result);
    //}
}
