using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Models
{
    public class Note
    {
        public int Id { get; set; }

        public int SerieId { get; set; }

        [NotMapped]
        public Serie Serie { get; set; } = null!;

        public int UserId { get; set; }

        [NotMapped]
        public UserApp User { get; set; } = null!;

        public string Commentaire { get; set; } = string.Empty;

        public int NbNote { get; set; }


    }
}
