using System.ComponentModel.DataAnnotations;

namespace ApiMandril.Models;

public class Profile
{
    [Key]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    [MaxLength(24, ErrorMessage = "La longitud maxima de 24 caracteres")]
    [MinLength(5, ErrorMessage = "La longitud minima de 5 caracteres")]
    public string biography { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    public string ImageUrl { get; set; }
    
    // Relación uno a uno con Profile
    // Clave foránea para la relación uno a uno con User
    public Guid UserId { get; set; }

    // Relación inversa con User
    public User User { get; set; }
}