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
    [JsonIgnore]
    public virtual Serie Serie { get; set; } = null!;

    [NotMapped]
    [DataMember]
    public List<Episode> Episodes { get; set; }
}
