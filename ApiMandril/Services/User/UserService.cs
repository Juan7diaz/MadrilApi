namespace ApiMandril.Services.User;
using Dto.user;
using ApiMandril.Repositories.User;
using AutoMapper;
using Models;


public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
    {
        IEnumerable<User> users = await _userRepository.GetAllUsersAsync();
        return _mapper.Map<IEnumerable<UserDto>>(users);
    }

    public async Task<UserDto> GetUserByIdAsync(Guid id)
    {
       User userFound = await _userRepository.GetUserByIdAsync(id);
       return _mapper.Map<UserDto>(userFound);
    }

    public async Task<UserDto> CreateUserAsync(UserDtoToSave userDtoToSave)
    {
        User user = _mapper.Map<User>(userDtoToSave);
        await _userRepository.AddUserAsync(user);
        return _mapper.Map<UserDto>(user);
    }

    public async Task<UserDto> UpdateUserAsync(Guid id, UserDtoToSave userDtoToSave)
    {
        User user = _mapper.Map<User>(userDtoToSave);
        user.Id = id; 
        await _userRepository.UpdateUserAsync(user);
        return _mapper.Map<UserDto>(user);
    }

    public async Task<bool> DeleteUserAsync(Guid id)
    {
       return await _userRepository.DeleteUserAsync(id);
    }
}