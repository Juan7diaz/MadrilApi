using System.ComponentModel.DataAnnotations;

namespace ApiMandril.Models;

public class Group
{
    [Key]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    [MaxLength(24, ErrorMessage = "La longitud maxima de 24 caracteres")]
    [MinLength(5, ErrorMessage = "La longitud minima de 5 caracteres")]
    public String Title { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    public String ImageUrl { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    [MaxLength(24, ErrorMessage = "La longitud maxima de 24 caracteres")]
    [MinLength(5, ErrorMessage = "La longitud minima de 5 caracteres")]
    public String Description { get; set; }
    
    public DateTime DateCreated { get; set; }
    
    public ICollection<UserGroup> UserGroups { get; set; } = new List<UserGroup>(); // Relación muchos a muchos con User
    
}