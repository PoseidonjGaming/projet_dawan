using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SerieDLL_EF.Models;

public partial class Episode
{
    public int Id { get; set; }

    public int SaisonId { get; set; }

    public string? Nom { get; set; }

    public string Resume { get; set; } = null!;

    public DateTime? DatePremDiff { get; set; }
}
