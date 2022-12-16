using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace SerieDLL_EF.Models;

public partial class Saison
{
    public int Id { get; set; }

    public int SerieId { get; set; }

    public short Numero { get; set; }

    public int NbEpisode { get; set; }

    public virtual Serie Serie { get; set; } = null!;

    [NotMapped]
    public List<Episode> Episodes { get; set; }
}
