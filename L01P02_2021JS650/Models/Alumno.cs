using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2021JS650.Models;

public partial class Alumno
{
    [Key]

    [Display(Name = "ID")]
    public int Id { get; set; }

    [Display(Name = "Código")]
    public string? Codigo { get; set; }

    [Display(Name = "Nombres")]
    public string? Nombre { get; set; }

    [Display(Name = "Apellidos")]
    public string? Apellidos { get; set; }

    [Display(Name = "DUI")]
    public int? Dui { get; set; }

    [Display(Name = "Estado")]
    public int? Estado { get; set; }
}
