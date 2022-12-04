using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace projet_dawan.Models;


public partial class Serie
{

    public int Id { get; set; }

    public string? Nom { get; set; }

    public DateTime? DateDiff { get; set; }

    public string? Resume { get; set; }

    public string? Affiche { get; set; }

    public string? UrlBa { get; set; }


    public virtual ICollection<Personnage> Personnages { get; } = new List<Personnage>();

    public virtual ICollection<Saison> Saisons { get; } = new List<Saison>();
}
