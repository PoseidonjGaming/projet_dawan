using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace SerieDLL_EF.Models;

[Serializable]
[DataContract]
public partial class Personnage
{
    [DataMember]
    [JsonIgnore]
    public int Id { get; set; }

    [DataMember]
    [JsonIgnore]
    public int ActeurId { get; set; }

    [DataMember]
    [JsonIgnore]
    public int SerieId { get; set; }

    [DataMember]
    public string Nom { get; set; } = null!;

    [DataMember]
    public virtual Acteur Acteur { get; set; } = null!;

    [JsonIgnore]
    public virtual Serie Serie { get; set; } = null!;

    [NotMapped]
    [JsonIgnore]
    public bool ShouldSerializeActeurs { get; set; }

    public bool ShouldSerializeSerie()
    {
        return false;
    }

    public bool ShouldSerializeActeur()
    {
        return ShouldSerializeActeurs;
    }

    

   
}
