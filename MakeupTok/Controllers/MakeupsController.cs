using AutoMapper;
using MakeupTok.Model;
using MakeupTok.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MakeupTok.Controllers;

[Route("api")]
[Authorize]
public class MakeupsController(IMakeupRepository repo,
    IMapper mapper) : Controller
{

    private IMakeupRepository _repository = repo;
    private IMapper _mapper = mapper;

    [HttpGet("makeups/next-makeup")]
    public async Task<IActionResult> GetNextMakeup()
    {
        var mkp = await _repository.GetNextByUser(int.Parse(HttpContext.User.Claims.First(x => x.Type == "UserId").Value));
        var mkpfinal = _mapper.Map<Model.Open.Makeup>(mkp);
        return Ok(mkpfinal);
    }

    [HttpDelete("makeups/{id}")]
    public async Task<IActionResult> DeleteMakeup(int id)
    {
        await _repository.Delete(id);
        return Ok();
    }

    [HttpPut("makeups/{id}")]
    public IActionResult UpdateMakeup()
    {
        return Ok(new Makeup());
    }

    [HttpPost("makeups")]
    public async Task<IActionResult> PostMakeup([FromBody] Model.Open.Makeup makeup)
    {
        return Ok(await _repository.Save(_mapper.Map<Makeup>(makeup)));
    }

}
