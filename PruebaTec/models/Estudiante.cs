using System.ComponentModel.DataAnnotations;
using PruebaTec.Models;

public class Estudiante
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Los Nombres son obligatorios.")]
    public string Nombres { get; set; } = string.Empty;
    [Required(ErrorMessage = "Los Apellidos son obligatorios.")]
    public string Apellidos { get; set; } = string.Empty;
    [Required(ErrorMessage = "La Fecha de Nacimiento es obligatoria.")]
    [DataType(DataType.Date)]
    [CustomValidation(typeof(Validaciones), nameof(Validaciones.ValidarFechaNacimiento))]
    public DateTime FechaNacimiento { get; set; }
    [Required(ErrorMessage = "La Dirección es Obligatoria.")]
    public string Direccion { get; set; } = string.Empty;
    [Required(ErrorMessage = "El Sexo es obligatorio.")]
    public string Sexo { get; set; } = string.Empty;
    [Required(ErrorMessage = "El CURP es obligatorio.")]
    public string CURP { get; set; } = string.Empty;
    [Required(ErrorMessage = "El Teléfono es obligatorio.")]
    public string Telefono { get; set; } = string.Empty;
    [Required(ErrorMessage = "El Email es obligatorio.")]
    public string Email { get; set; } = string.Empty;
    public int IdCarrera { get; set; }
    public bool EsBecado { get; set; }
    public string Modalidad { get; set; } = string.Empty;

    public string? DescripcionPersonal { get; set; } = string.Empty;
    public bool TieneMascotas { get; set; } = false;
    public string? TiposMascotas { get; set; } = string.Empty;
    public string? HorarioComida { get; set; } = string.Empty;

    public Carrera? Carrera { get; set; }
}

public static class Validaciones {
    public static ValidationResult ValidarFechaNacimiento(DateTime? fecha, ValidationContext context)
    {
        if (fecha == null)
            return new ValidationResult("La Fecha de Nacimiento es obligatoria");

        if (fecha > DateTime.Today)
            return new ValidationResult("La fecha de nacimiento no puede ser futura");

        return ValidationResult.Success;
    }
}
