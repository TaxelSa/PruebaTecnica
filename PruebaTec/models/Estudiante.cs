using PruebaTec.Models;

public class Estudiante
{
    public int Id { get; set; }
    public string Nombres  { get; set; } = string.Empty;
    public string Apellidos { get; set; } = string.Empty;
    public DateTime FechaNacimiento { get; set; }
    public string Direccion { get; set; } = string.Empty;
    public string Sexo { get; set; } = string.Empty;
    public string CURP { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int IdCarrera { get; set; }
    public bool EsBecado { get; set; }
    public string Modalidad { get; set; } = string.Empty;

    public string? DescripcionPersonal { get; set; } = string.Empty;
    public bool TieneMascotas { get; set; } = false;
    public string? TiposMascotas { get; set; } = string.Empty;
    public string? HorarioComida { get; set; } = string.Empty;

public Carrera? Carrera { get; set;}    
}
