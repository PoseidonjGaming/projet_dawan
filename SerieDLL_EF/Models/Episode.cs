using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SerieDLL_EF.Models;

[Serializable]
[DataContract]
public partial class Episode
{
    [DataMember]
    public int Id { get; set; }

    public int SaisonId { get; set; }

    public string? Nom { get; set; }

    public string Resume { get; set; } = null!;

    public DateTime? DatePremDiff { get; set; }
}
