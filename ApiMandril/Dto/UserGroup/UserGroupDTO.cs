using ApiMandril.Dto.Group;
using ApiMandril.Dto.user;

namespace ApiMandril.Dto.UserGroup;

public class UserGroupDto
{
    public Guid UserId { get; set; }
    public UserDto User { get; set; }
    
    public Guid GroupId { get; set; }
    public GroupDto Group { get; set; }
    
}