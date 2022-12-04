using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace projet_dawan.Models;

[Serializable]
[DataContract]
public partial class Episode
{
    [DataMember]
    public int Id { get; set; }

    public int SaisonId { get; set; }

    [DataMember]
    public string? Nom { get; set; }

    [DataMember]
    public string Resume { get; set; } = null!;

    [DataMember]
    public DateTime? DatePremDiff { get; set; }
}
