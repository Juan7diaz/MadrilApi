using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiMandril.Models;

[Table("User")]
public class User
{
    [Key]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    [MaxLength(24, ErrorMessage = "La longitud maxima de 24 caracteres")]
    [MinLength(5, ErrorMessage = "La longitud minima de 5 caracteres")]
    public string Username { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    public DateTime BirthDay { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    [EmailAddress(ErrorMessage = "Ingresa una fecha valida")]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    [MaxLength(24, ErrorMessage = "La longitud maxima de 24 caracteres")]
    [MinLength(5, ErrorMessage = "La longitud minima de 5 caracteres")]
    public string Password { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    [MaxLength(24, ErrorMessage = "La longitud maxima de 24 caracteres")]
    [MinLength(5, ErrorMessage = "La longitud minima de 5 caracteres")]
    public string Address { get; set; }
    
    public Profile Profile { get; set; } // Relación uno a uno con Profile
    
    public ICollection<Post> Posts { get; } = new List<Post>(); // Relacion uni a muchos con Posts
    
    public ICollection<UserGroup> UserGroups { get; set; } = new List<UserGroup>();  // Relación muchos a muchos con Group
    
}