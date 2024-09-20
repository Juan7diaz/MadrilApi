namespace ApiMandril.Repositories.Profile;
using Microsoft.EntityFrameworkCore;
using Data;
using Models;

public class ProfileRepository : IProfileRepository
{
    
    private readonly ApplicationDbContext _context;
    
    public ProfileRepository(ApplicationDbContext context)
    {
        this._context = context;
    }
    
    public async Task<IEnumerable<Profile>> GetAllProfilesAsync()
    {
        return await _context.Profiles.ToListAsync();
    }

    public async Task<Profile> GetProfileByIdAsync(Guid id)
    {
        return await _context.Profiles.FindAsync(id);
    }

    public async Task AddProfileAsync(Profile profile)
    {
        await _context.Profiles.AddAsync(profile);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateProfileAsync(Profile profile)
    {
        _context.Profiles.Update(profile);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProfileAsync(Guid id)
    {
        var profile = await _context.Profiles.FindAsync(id);
        if (profile != null)
        {
            _context.Profiles.Remove(profile);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<Profile> GetProfileByUserIdAsync(Guid userId)
    {
        return await _context.Profiles.FirstOrDefaultAsync(p => p.UserId == userId);
    }
}