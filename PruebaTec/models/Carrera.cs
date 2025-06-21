using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PruebaTec.Models;

public class Carrera
{
  [Key]
    public int IdCarrera
    {
        get; set;
    }
    public string NombreCarrera { get; set; } = string.Empty;

    public ICollection<Estudiante> Estudiantes
    {
        get; set;
    } = new List<Estudiante>();
}

