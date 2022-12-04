using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace projet_dawan.Models;

[Serializable]
[DataContract]
public partial class Saison
{
    [DataMember]
    public int Id { get; set; }

    public int SerieId { get; set; }

    [DataMember]
    public short Numero { get; set; }

    [DataMember]
    public int NbEpisode { get; set; }

    public virtual Serie Serie { get; set; } = null!;

    [NotMapped]
    [DataMember]
    public List<Episode> Episodes { get; set;}
}
