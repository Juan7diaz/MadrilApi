using ApiMandril.Dto.user;

namespace ApiMandril.Services.User;

public interface IUserService
{
    Task<IEnumerable<UserDto>> GetAllUsersAsync();
    Task<UserDto> GetUserByIdAsync(Guid id);
    Task<UserDto> CreateUserAsync(UserDtoToSave userDtoToSave);
    Task<UserDto> UpdateUserAsync(Guid id, UserDtoToSave userDtoToSave);
    Task<bool> DeleteUserAsync(Guid id);
}