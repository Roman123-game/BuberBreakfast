using Microsoft.AspNetCore.Mvc;
using BuberBreakfast.Contracts.Breakfast;

namespace BuberBreakfast.Controllers;

[ApiController]
public class BreakfastsController : ControllerBase{


 [HttpPost("//breakfasts")]

  public IActionResult CreateBreakfast(CreateBreakfatRequest request){
    return Ok(request);
  }
}

