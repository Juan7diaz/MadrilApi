using Microsoft.EntityFrameworkCore;

namespace ApiMandril.Repositories.Group;
using Data;

public class GroupRepository : IGroupRepository
{
    
    private readonly ApplicationDbContext _context;

    public GroupRepository(ApplicationDbContext context)
    {
        this._context = context;
    }
    
    public async Task<IEnumerable<Models.Group>> GetAllGroupsAsync()
    {
        return await _context.Groups.ToListAsync();
    }

    public async Task<Models.Group> GetGroupByIdAsync(Guid id)
    {
        return await _context.Groups.FindAsync(id);
    }

    public async Task AddGroupAsync(Models.Group group)
    {
        await _context.Groups.AddAsync(group);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateGroupAsync(Models.Group group)
    {
        _context.Groups.Update(group);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteGroupAsync(Guid id)
    {
        var group = await _context.Groups.FindAsync(id);
        if (group != null)
        {
            _context.Groups.Remove(group);
            await _context.SaveChangesAsync();
        }
    }
}