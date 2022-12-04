using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkApp.Models;

[Table("acteur")]
public partial class Acteur
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nom")]
    [StringLength(255)]
    [Unicode(false)]
    public string Nom { get; set; } = null!;

    [Column("prenom")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Prenom { get; set; }

    [InverseProperty("Acteur")]
    public virtual ICollection<Personnage> Personnages { get; set; } = new List<Personnage>();
}
