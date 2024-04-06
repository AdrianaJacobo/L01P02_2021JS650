using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2021JS650.Models;

public partial class Materia
{
    [Key]
    [Display(Name = "ID")]
    public int Id { get; set; }

    [Display(Name = "Nombre Materia")]
    public string? Materia1 { get; set; }

    [Display(Name = "Unidades Valorativas")]
    public int? UnidadesValorativas { get; set; }

    [Display(Name = "Estado")]
    [StringLength(1, ErrorMessage = "La cantidad de caracteres permitida es de 1 caracter")]
    public string? Estado { get; set; }
}
