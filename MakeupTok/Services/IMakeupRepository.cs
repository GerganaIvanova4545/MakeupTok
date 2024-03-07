using MakeupTok.Model;

namespace MakeupTok.Services;

public interface IMakeupRepository
{

    public Task<Makeup> GetMakeupById(int id);

    public Task<Makeup> SaveMakeup(Makeup makeup);

    public Task<Makeup> GetNextMakeup(int userId);

}
