namespace ApiMandril.Repositories.Group;
using Models;

public interface IGroupRepository
{
    Task<IEnumerable<Group>> GetAllGroupsAsync();
    Task<Group> GetGroupByIdAsync(Guid id);
    Task AddGroupAsync(Group group);
    Task UpdateGroupAsync(Group group);
    Task DeleteGroupAsync(Guid id);
}