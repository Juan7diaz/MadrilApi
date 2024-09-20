using System.ComponentModel.DataAnnotations;

namespace ApiMandril.Dto.Group;

public class GroupDtoToSave
{
    [Required]
    [MaxLength(24)]
    public string Title { get; set; }
    
    [Required]
    [MaxLength(500)]
    public string Description { get; set; }
    
    [Required]
    public string ImageUrl { get; set; }
}