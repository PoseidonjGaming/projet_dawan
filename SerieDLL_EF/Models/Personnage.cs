using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SerieDLL_EF.Models;

[Serializable]
[DataContract]
public partial class Personnage
{
    [DataMember]
    public int Id { get; set; }

    public int ActeurId { get; set; }

    public int SerieId { get; set; }

    public string Nom { get; set; } = null!;

    public virtual Acteur Acteur { get; set; } = null!;

    public virtual Serie Serie { get; set; } = null!;
}
