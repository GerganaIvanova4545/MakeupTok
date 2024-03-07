using MakeupTok.Model;

namespace MakeupTok.Services;

public interface IUserRepository
{

    public Task<User[]> GetUsersAsync();

    public Task<User> SaveUserAsync(User user);

    public Task<bool> UserExistsAsync(string username);

    public Task<User> AuthenticateUserAsync(string username, string password);

    public Task<User> UpdateUserAsync(User user);

    public Task DeleteUserAsync(string username);

}
