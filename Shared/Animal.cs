using System.ComponentModel.DataAnnotations;

namespace Shared;

public class Animal
{
    [StringLength(10, MinimumLength = 3, ErrorMessage = "Namnet måste vara mellan 3 och 10 tecken långt!")]
    [Required(ErrorMessage = "Fyll i namnet bror!")]
    public string Name { get; set; }
    [Required]
    public string Type { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    [Phone]
    public string Phone { get; set; }
}