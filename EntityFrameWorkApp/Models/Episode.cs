using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkApp.Models;

[Table("episode")]
public partial class Episode
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("saison_id")]
    public int SaisonId { get; set; }

    [Column("nom")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Nom { get; set; }

    [Column("resume")]
    [Unicode(false)]
    public string Resume { get; set; } = null!;

    [Column("date_prem_diff", TypeName = "date")]
    public DateTime? DatePremDiff { get; set; }
}
