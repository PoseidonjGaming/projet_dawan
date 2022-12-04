using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkApp.Models;

[Table("saison")]
public partial class Saison
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("serie_id")]
    public int SerieId { get; set; }

    [Column("numero")]
    public short Numero { get; set; }

    [Column("nb_episode")]
    public int NbEpisode { get; set; }

    [ForeignKey("SerieId")]
    [InverseProperty("Saisons")]
    public virtual Serie Serie { get; set; } = null!;
}
