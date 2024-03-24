using MakeupTok.Model;

namespace MakeupTok.Services;

public interface IMakeupRepository
{

    public Task<Makeup> GetById(int id);

    public Task<Makeup> Save(Makeup makeup);

    public Task<Makeup> Delete(Makeup makeup);

    public Task<Makeup> GetNext(int userId);

}
