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

    public bool ShouldSerializeId()
    {
        return false;
    }

    public bool ShouldSerializePersonnages()
    {
        return false;
    }
}
