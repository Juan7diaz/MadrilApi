namespace ApiMandril.Repositories.UserGroup;
using Microsoft.EntityFrameworkCore;
using Data;
using Models;

public class UserGroupRepository : IUserGroupRepository
{
    private readonly ApplicationDbContext _context;
    
    public UserGroupRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task AddUserToGroupAsync(Guid userId, Guid groupId)
    {
        var userGroup = new UserGroup()
        {
            UserId = userId,
            GroupId = groupId
        };
        await _context.UserGroups.AddAsync(userGroup);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveUserFromGroupAsync(Guid userId, Guid groupId)
    {
        var userGroup = await _context.UserGroups
            .FirstOrDefaultAsync(ug => ug.UserId == userId && ug.GroupId == groupId);
            
        if (userGroup != null)
        {
            _context.UserGroups.Remove(userGroup);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Group>> GetGroupsForUserAsync(Guid userId)
    {
        return await _context.UserGroups
            .Where(ug => ug.UserId == userId)
            .Select(ug => ug.Group)
            .ToListAsync();
    }

    public async Task<IEnumerable<User>> GetUsersInGroupAsync(Guid groupId)
    {
        return await _context.UserGroups
            .Where(ug => ug.GroupId == groupId)
            .Select(ug => ug.User)
            .ToListAsync();
    }
}