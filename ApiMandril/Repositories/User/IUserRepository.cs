namespace ApiMandril.Repositories.User;
using ApiMandril.Models;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllUsersAsync();
    Task<User> GetUserByIdAsync(Guid id);
    Task AddUserAsync(Models.User user);
    Task UpdateUserAsync(User user);
    Task<bool> DeleteUserAsync(Guid id);
}