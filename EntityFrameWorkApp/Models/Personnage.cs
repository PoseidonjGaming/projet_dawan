using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkApp.Models;

[Table("personnage")]
public partial class Personnage
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("acteur_id")]
    public int ActeurId { get; set; }

    [Column("serie_id")]
    public int SerieId { get; set; }

    [Column("nom")]
    [StringLength(255)]
    [Unicode(false)]
    public string Nom { get; set; } = null!;

    [ForeignKey("ActeurId")]
    [InverseProperty("Personnages")]
    public virtual Acteur Acteur { get; set; } = null!;

    [ForeignKey("SerieId")]
    [InverseProperty("Personnages")]
    public virtual Serie Serie { get; set; } = null!;
}
