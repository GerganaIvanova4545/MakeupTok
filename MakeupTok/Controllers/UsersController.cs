using AutoMapper;
using MakeupTok.Model;
using MakeupTok.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MakeupTok.Controllers;

[Route("api/users")]
[Authorize]
public class UsersController(IUserRepository repo,
    IMapper mapper) : Controller
{

    private IUserRepository _repository = repo;
    private IMapper _mapper = mapper;

    [HttpPut("{id}")]
    public IActionResult UpdateMakeup()
    {
        return Ok(new Makeup());
    }

    [HttpPost()]
    public async Task<IActionResult> Register([FromBody] Model.Open.User user)
    {
        return Ok(await _repository.SaveUserAsync(_mapper.Map<User>(user)));
    }

}
