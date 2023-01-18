using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace SerieDLL_EF.Models;

[Serializable]
[DataContract]
public partial class Saison
{
    [JsonIgnore]
    public int Id { get; set; }

    [DataMember]
    [JsonIgnore]
    public int SerieId { get; set; }

    [DataMember]
    public short Numero { get; set; }

    [DataMember]
    public int NbEpisode { get; set; }

    [DataMember]
    [NotMapped]
    public virtual Serie Serie { get; set; } = null!;

    [NotMapped]
    [DataMember]
    public List<Episode> Episodes { get; set; } = new List<Episode>();

    [NotMapped]
    public bool ShouldExportSerie { get; set; }

    [NotMapped]
    public bool ShouldExportEpisode { get; set; }

    public bool ShouldSerializeSerie()
    {
        return ShouldExportSerie;
    }
    public bool ShouldSerializeEpisodes()
    {
        return ShouldExportEpisode;
    }
}
