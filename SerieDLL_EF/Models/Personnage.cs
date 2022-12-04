using System;
using System.Collections.Generic;

namespace projet_dawan.Models;

public partial class Personnage
{
    public int Id { get; set; }

    public int ActeurId { get; set; }

    public int SerieId { get; set; }

    public string Nom { get; set; } = null!;

    public virtual Acteur Acteur { get; set; } = null!;

    public virtual Serie Serie { get; set; } = null!;
}
