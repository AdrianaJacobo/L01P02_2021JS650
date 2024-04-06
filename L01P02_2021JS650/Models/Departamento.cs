using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2021JS650.Models;

public partial class Departamento
{
    [Key]
    [Display(Name = "ID")]
    public int Id { get; set; }


    [Display(Name = "Departamento")]
    public string? Departamento1 { get; set; }
}
