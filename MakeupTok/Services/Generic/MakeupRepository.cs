using MakeupTok.Model;
using Microsoft.EntityFrameworkCore;

namespace MakeupTok.Services.Generic;

public class MakeupRepository(MakeupTokContext cont) : IMakeupRepository
{

    private readonly MakeupTokContext _context = cont;

    public async Task<Makeup> GetMakeupById(int id)
    {
        _context.Database.EnsureCreated();
        return await _context.Makeups.Include(x => x.Steps).FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Makeup> GetNextMakeup(int userId)
    {
        _context.Database.EnsureCreated();
        return await _context.Makeups.Include(x => x.Steps).FirstOrDefaultAsync();
    }

    public async Task<Makeup> SaveMakeup(Makeup makeup)
    {
        _context.Database.EnsureCreated();
        _context.Makeups.Add(makeup);
        await _context.SaveChangesAsync();
        return makeup;
    }
}
