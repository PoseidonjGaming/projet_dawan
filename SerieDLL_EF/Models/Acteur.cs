using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace SerieDLL_EF.Models;

[Serializable]
[DataContract]
public partial class Acteur
{
    [JsonIgnore]
    public int Id { get; set; }

    [DataMember]
    public string Nom { get; set; } = null!;

    [DataMember]
    public string? Prenom { get; set; }

    public virtual ICollection<Personnage> Personnages { get; set; } = new List<Personnage>();

    [JsonIgnore]
    [NotMapped]
    public bool ShouldExportPersonnage { get; set; }

    public Acteur() { }

    public bool ShouldSerializePersonnages()
    {
        return ShouldExportPersonnage;
    }

}
