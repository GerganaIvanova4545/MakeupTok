using MakeupTok.Model;

namespace MakeupTok.Services.Generic;

public class UserRepository(MakeupTokContext cont) : IUserRepository
{

    private readonly MakeupTokContext _context = cont;

    public Task<User> AuthenticateUserAsync(string username, string password)
    {

    }

    public Task DeleteUserAsync(string username)
    {

    }

    public Task<User[]> GetUsersAsync()
    {

    }

    public Task<User> SaveUserAsync(User user)
    {

    }

    public Task<User> UpdateUserAsync(User user)
    {

    }

    public Task<bool> UserExistsAsync(string username)
    {

    }
}
