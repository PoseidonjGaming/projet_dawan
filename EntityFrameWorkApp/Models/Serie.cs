using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkApp.Models;

[Table("serie")]
public partial class Serie
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nom")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Nom { get; set; }

    [Column("date_diff", TypeName = "date")]
    public DateTime? DateDiff { get; set; }

    [Column("resume")]
    [Unicode(false)]
    public string? Resume { get; set; }

    [Column("affiche")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Affiche { get; set; }

    [Column("url_ba")]
    [StringLength(255)]
    [Unicode(false)]
    public string? UrlBa { get; set; }

    [Column("type")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Type { get; set; }

    [InverseProperty("Serie")]
    public virtual ICollection<Personnage> Personnages { get; } = new List<Personnage>();

    [InverseProperty("Serie")]
    public virtual ICollection<Saison> Saisons { get; } = new List<Saison>();
}
