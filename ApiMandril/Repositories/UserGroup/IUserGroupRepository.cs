namespace ApiMandril.Repositories.UserGroup;
using Models;

public interface IUserGroupRepository
{
    Task AddUserToGroupAsync(Guid userId, Guid groupId);
    Task RemoveUserFromGroupAsync(Guid userId, Guid groupId);
    Task<IEnumerable<Group>> GetGroupsForUserAsync(Guid userId);
    Task<IEnumerable<User>> GetUsersInGroupAsync(Guid groupId);
}