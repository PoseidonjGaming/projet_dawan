using System.Runtime.Serialization;

namespace SerieDLL_EF.Models;

[Serializable]
[DataContract]
public partial class Serie
{
    [DataMember]
    public int Id { get; set; }

    public string? Nom { get; set; }

    public DateTime? DateDiff { get; set; }

    public string? Resume { get; set; }

    public string? Affiche { get; set; }

    public string? UrlBa { get; set; }

    public virtual ICollection<Personnage> Personnages { get; set; } = new List<Personnage>();


    public virtual ICollection<Saison> Saisons { get; set; } = new List<Saison>();
}
