using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Models
{
    public class Note
    {
        public int Id { get; set; }

        public int SerieId { get; set; }

        public Serie Serie { get; set; } = new();

        public int UserId { get; set; }

        public UserApp User { get; set; } = new();

        public string Commentaire { get; set; } = string.Empty;


    }
}
