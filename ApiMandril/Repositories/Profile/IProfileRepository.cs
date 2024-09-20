namespace ApiMandril.Repositories.Profile;
using Models;

public interface IProfileRepository
{
    Task<IEnumerable<Profile>> GetAllProfilesAsync();
    Task<Profile> GetProfileByIdAsync(Guid id);
    Task AddProfileAsync(Profile profile);
    Task UpdateProfileAsync(Profile profile);
    Task DeleteProfileAsync(Guid id);
    Task<Profile> GetProfileByUserIdAsync(Guid userId);
}