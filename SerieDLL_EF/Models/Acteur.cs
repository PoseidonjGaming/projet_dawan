using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace projet_dawan.Models;

[Serializable]
[DataContract]
public partial class Acteur
{
    [DataMember]
    public int Id { get; set; }

    [DataMember] 
    public string Nom { get; set; } = null!;

    [DataMember]
    public string? Prenom { get; set; }

    public virtual ICollection<Personnage> Personnages { get; } = new List<Personnage>();
}
