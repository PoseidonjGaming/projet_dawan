using System;
using System.Collections.Generic;

namespace projet_dawan.Models;

public partial class Acteur
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public string? Prenom { get; set; }

    public virtual ICollection<Personnage> Personnages { get; } = new List<Personnage>();
}
