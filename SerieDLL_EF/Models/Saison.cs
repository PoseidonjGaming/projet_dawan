using System;
using System.Collections.Generic;

namespace projet_dawan.Models;

public partial class Saison
{
    public int Id { get; set; }

    public int SerieId { get; set; }

    public short Numero { get; set; }

    public int NbEpisode { get; set; }

    public virtual Serie Serie { get; set; } = null!;
}
