using System.ComponentModel.DataAnnotations;

namespace ApiMandril.Dto.Profile;

public class ProfileDtoToSave
{
    [Required]
    [MaxLength(24)]
    public string Biography { get; set; }
    
    [Required]
    public string ImageUrl { get; set; }
}