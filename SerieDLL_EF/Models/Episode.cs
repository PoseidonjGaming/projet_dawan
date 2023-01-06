using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace SerieDLL_EF.Models;

[Serializable]
[DataContract]
public partial class Episode
{
    [DataMember]
    [JsonIgnore]
    public int Id { get; set; }

    [DataMember]
    [JsonIgnore]
    public int SaisonId { get; set; }

    [DataMember]
    public string? Nom { get; set; }

    [DataMember]
    public string Resume { get; set; } = null!;

    [DataMember]
    public DateTime? DatePremDiff { get; set; }

    [DataMember]
    [NotMapped]
    public Saison Saison { get; set; }

    [NotMapped]
    public bool ShouldExportSaisons { get; set; }

    public bool ShouldSerializeSaison()
    {
        return ShouldExportSaisons;
    }

}
