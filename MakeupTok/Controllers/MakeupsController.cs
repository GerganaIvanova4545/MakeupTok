using AutoMapper;
using MakeupTok.Model;
using MakeupTok.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MakeupTok.Controllers;

[Route("api/makeups")]
[Authorize]
public class MakeupsController(IMakeupRepository repo,
    IMapper mapper) : Controller
{

    private IMakeupRepository _repository = repo;
    private IMapper _mapper = mapper;

    [HttpGet("next-makeup")]
    public async Task<IActionResult> GetNextMakeup()
    {
        var mkp = await _repository.GetNextByUser(int.Parse(HttpContext.User.Claims.First(x => x.Type == "UserId").Value));
        var mkpfinal = _mapper.Map<Model.Open.Makeup>(mkp);
        return Ok(mkpfinal);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMakeup(int id)
    {
        await _repository.Delete(id);
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateMakeup()
    {
        return Ok(new Makeup());
    }

    [HttpPost()]
    public async Task<IActionResult> PostMakeup([FromBody] Model.Open.Makeup makeup)
    {
        return Ok(await _repository.Save(_mapper.Map<Makeup>(makeup)));
    }

}
