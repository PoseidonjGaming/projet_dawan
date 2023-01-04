using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace SerieDLL_EF.Models;

[Serializable]
[DataContract]
public partial class Serie
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string? Nom { get; set; }

    [DataMember]
    public DateTime? DateDiff { get; set; }

    [DataMember]
    public string? Resume { get; set; }

    [DataMember]
    public string? Affiche { get; set; }

    [DataMember]
    public string? UrlBa { get; set; }

    [DataMember]
    public virtual ICollection<Personnage> Personnages { get; set; } = new List<Personnage>();

    [NotMapped]
    public bool ShouldSerializePersonnage { get; set; }

    [NotMapped]
    public bool ShouldSerializeSaisons { get; set; }

    [DataMember]
    public virtual ICollection<Saison> Saisons { get; set; } = new List<Saison>();

    public bool ShouldSerializePersonnages()
    {
        return ShouldSerializePersonnage;
    }

    public bool ShouldSerializeSaison()
    {
        return ShouldSerializeSaisons;
    }

    public bool ShouldSerializeId()
    {
        return false;
    }


}
