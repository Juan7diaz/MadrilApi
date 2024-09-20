using ApiMandril.Dto.Post;
using ApiMandril.Dto.Profile;
using ApiMandril.Dto.UserGroup;

namespace ApiMandril.Dto.user;

public class UserDto
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public DateTime BirthDay { get; set; }
    public string Address { get; set; }
    public ProfileDto Profile { get; set; }
    public ICollection<PostDto> Posts { get; set; }
    public ICollection<UserGroupDto> UserGroups { get; set; }
}