using AutoMapper;
using MakeupTok.Model;
using MakeupTok.Services;
using Microsoft.AspNetCore.Mvc;

namespace MakeupTok.Controllers;

[Route("api")]
public class MakeupsController(IMakeupRepository repo,
    IMapper mapper) : Controller
{

    private IMakeupRepository _repository = repo;
    private IMapper _mapper = mapper;

    [HttpGet("makeups/next-makeup")]
    public async Task<IActionResult> GetNextMakeup()
    {
        return Ok(await _repository.GetNextMakeup(0));
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
    public async Task<IActionResult> PostMakeup([FromBody] Model.Open.Makeup makeup)
    {
        return Ok(await _repository.SaveMakeup(_mapper.Map<Makeup>(makeup)));
    }

}
