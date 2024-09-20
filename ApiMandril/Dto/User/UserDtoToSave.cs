using System.ComponentModel.DataAnnotations;

namespace ApiMandril.Dto.user;

public class UserDtoToSave
{
    [Required]
    [MaxLength(24)]
    public string Username { get; set; }
    
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required]
    public DateTime BirthDay { get; set; }
    
    [Required]
    [MaxLength(24)]
    public string Password { get; set; }
    
    [Required]
    [MaxLength(24)]
    public string Address { get; set; }
}