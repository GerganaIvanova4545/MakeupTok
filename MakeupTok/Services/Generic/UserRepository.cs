using MakeupTok.Model;

namespace MakeupTok.Services.Generic;

public class UserRepository : IUserRepository
{
    public Task<User> AuthenticateUserAsync(string username, string password)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUserAsync(string username)
    {
        throw new NotImplementedException();
    }

    public Task<User[]> GetUsersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<User> SaveUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> UpdateUserAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UserExistsAsync(string username)
    {
        throw new NotImplementedException();
    }
}
