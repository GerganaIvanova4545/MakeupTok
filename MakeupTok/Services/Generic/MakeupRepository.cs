using MakeupTok.Model;
using Microsoft.EntityFrameworkCore;

namespace MakeupTok.Services.Generic;

public class MakeupRepository(MakeupTokContext cont) : IMakeupRepository
{

    private readonly MakeupTokContext _context = cont;

    public async Task<Makeup> GetById(int id)
    {
        _context.Database.EnsureCreated();
        return await _context.Makeups.Include(x => x.Steps).FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Makeup> GetNext(int userId)
    {
        _context.Database.EnsureCreated();
        return await _context.Makeups.Include(x => x.Steps).FirstOrDefaultAsync();
    }

    public async Task<Makeup> Save(Makeup makeup)
    {
        _context.Database.EnsureCreated();
        var usr = new User() { Username = "mani", Email = "mani", Password = "mani",  ProfileImage = "sdsddsd" };
        _context.Users.Add(usr);
        await _context.SaveChangesAsync();
        makeup.User = usr;
        _context.Makeups.Add(makeup);
        await _context.SaveChangesAsync();
        return makeup;
    }
}
