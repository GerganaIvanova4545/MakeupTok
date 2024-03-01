using MakeupTok.Model;
using Microsoft.AspNetCore.Mvc;

namespace MakeupTok.Controllers;

[Route("api")]
public class MakeupsController : Controller
{

    [HttpGet("makeups/next-makeup")]
    public IActionResult GetNextMakeup()
    {
        return Ok(new Makeup());
    }

    [HttpDelete("makeups/{id}")]
    public IActionResult DeleteMakeup()
    {
        return Ok(new Makeup());
    }

    [HttpPut("makeups/{id}")]
    public IActionResult UpdateMakeup()
    {
        return Ok(new Makeup());
    }

    [HttpPost("makeups")]
    public IActionResult PostMakeup()
    {
        return Ok(new Makeup());
    }

}
