using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace SerieDLL_EF.Models;

public partial class Personnage
{
    public int Id { get; set; }

    public int ActeurId { get; set; }

    public int SerieId { get; set; }

    public string Nom { get; set; } = null!;

    public virtual Acteur Acteur { get; set; } = null!;

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

    public bool ShouldSerializeActeurId()
    {
        return false;
    }

    public bool ShouldSerializeSerieId()
    {
        return false;
    }

    public bool ShouldSerializeId()
    {
        return false;
    }
}
