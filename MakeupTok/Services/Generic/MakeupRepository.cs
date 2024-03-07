using MakeupTok.Model;

namespace MakeupTok.Services.Generic;

public class MakeupRepository : IMakeupRepository
{
    public Task<Makeup> GetMakeupById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Makeup> GetNextMakeup(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<Makeup> SaveMakeup(Makeup makeup)
    {
        throw new NotImplementedException();
    }
}
