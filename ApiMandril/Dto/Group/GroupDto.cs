using ApiMandril.Dto.user;

namespace ApiMandril.Dto.Group;

public class GroupDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public DateTime DateCreated { get; set; }
    public ICollection<UserDto> Users { get; set; }
}