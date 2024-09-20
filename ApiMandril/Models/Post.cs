using System.ComponentModel.DataAnnotations;

namespace ApiMandril.Models;

public class Post
{
    [Key]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    [MaxLength(24, ErrorMessage = "La longitud maxima de 24 caracteres")]
    [MinLength(5, ErrorMessage = "La longitud minima de 5 caracteres")]
    public string Title { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    [MaxLength(24, ErrorMessage = "La longitud maxima de 24 caracteres")]
    [MinLength(5, ErrorMessage = "La longitud minima de 5 caracteres")]
    public string Content { get; set; }
    
    [Required(ErrorMessage = "El campo es requerido")]
    public DateTime DateCreated { get; set; }
    
    public Guid UserId { get; set; } // Required foreign key property
    public User User { get; set; } = null!; // Required reference navigation to principal
}