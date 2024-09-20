using System.ComponentModel.DataAnnotations;

namespace ApiMandril.Dto.UserGroup;

public class UserGroupDtoToSave
{
    [Required]
    public Guid UserId { get; set; }
    
    [Required]
    public Guid GroupId { get; set; }
}