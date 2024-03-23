using MakeupTok.Model;

namespace MakeupTok.Services.Generic;

public class UserRepository(MakeupTokContext cont) : IUserRepository
{

    private readonly MakeupTokContext _context = cont;

    public Task<User> AuthenticateUserAsync(string username, string password)
    {
        _context.Database.EnsureCreated();
        throw new NotImplementedException();
    }

    public Task DeleteUserAsync(string username)
    {
        _context.Database.EnsureCreated();
        throw new NotImplementedException();
    }

    public Task<User[]> GetUsersAsync()
    {
        _context.Database.EnsureCreated();
        throw new NotImplementedException();
    }

    public Task<User> SaveUserAsync(User user)
    {
        _context.Database.EnsureCreated();
        throw new NotImplementedException();
    }

    public Task<User> UpdateUserAsync(User user)
    {
        _context.Database.EnsureCreated();
        throw new NotImplementedException();
    }

    public Task<bool> UserExistsAsync(string username)
    {
        _context.Database.EnsureCreated();
        throw new NotImplementedException();
    }
}
