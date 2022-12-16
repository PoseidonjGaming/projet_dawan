using projet_dawan.Models;
using SerieDLL_EF.Interface;
using SerieDLL_EF.Service;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SerieDLL_EF.Models;

public partial class Acteur
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public string? Prenom { get; set; }

    public virtual ICollection<Personnage> Personnages { get; } = new List<Personnage>();

    public Acteur() { }

    public Acteur(string nom, string prenom)
    {
        Nom = nom;
        Prenom = prenom;
    }
}
