using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace projet_dawan.Models;

[Serializable]
[DataContract]
public partial class Serie
{
    [DataMember]
    public int Id { get; set; }

    public string? Nom { get; set; }

    public DateTime? DateDiff { get; set; }

    public string? Resume { get; set; }

    public string? Affiche { get; set; }

    public string? UrlBa { get; set; }

    public virtual ICollection<Personnage> Personnages { get; set; } = new List<Personnage>();

    
    public virtual ICollection<Saison> Saisons { get; set; } = new List<Saison>();
}
