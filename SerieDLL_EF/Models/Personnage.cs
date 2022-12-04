﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace projet_dawan.Models;

[Serializable]
[DataContract]
public partial class Personnage
{
    [DataMember]
    public int Id { get; set; }

    public int ActeurId { get; set; }

    public int SerieId { get; set; }

    [DataMember]
    public string Nom { get; set; } = null!;

    [DataMember]
    public virtual Acteur Acteur { get; set; } = null!;

    public virtual Serie Serie { get; set; } = null!;
}
