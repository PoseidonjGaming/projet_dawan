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

    [DataMember]
    public string? Nom { get; set; }

    [DataMember]
    public DateTime? DateDiff { get; set; }

    [DataMember]
    public string? Resume { get; set; }

    [DataMember]
    public string? Affiche { get; set; }

    [DataMember]
    public string? UrlBa { get; set; }

    [DataMember]
    public virtual ICollection<Personnage> Personnages { get; set; } = new List<Personnage>();

    [DataMember]
    public virtual ICollection<Saison> Saisons { get; set; } = new List<Saison>();
}
