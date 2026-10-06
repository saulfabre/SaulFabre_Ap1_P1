using System.ComponentModel.DataAnnotations;

namespace SaulFabre_Ap1_P1.Models;

public class Autores
{
    [Key]
    public int IdAutor { get; set; }

    [Required(ErrorMessage = "El campo de Nombres es obligatorio.")]
    public string Nombres { get; set; } = "";

    [Required(ErrorMessage = "El campo de Nacionalidad es obligatorio.")]
    public string Nacionalidad { get; set; } = "";

    public DateOnly FechaNacimiento { get; set; }

    public decimal Sueldo { get; set; }
}
