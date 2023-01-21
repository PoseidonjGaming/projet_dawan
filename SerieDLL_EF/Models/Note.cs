using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerieDLL_EF.Models
{
    [Serializable]
    [DataContract]
    public class Note
    {
        [JsonIgnore]
        public int Id { get; set; }

        public int SerieId { get; set; }

        [DataMember]
        [NotMapped]
        public Serie Serie { get; set; } = null!;

        public int UserId { get; set; }

        [DataMember]
        [NotMapped]
        public UserApp User { get; set; } = null!;

        [DataMember]
        public string Commentaire { get; set; } = string.Empty;

        [DataMember]
        public int NbNote { get; set; }

        [DataMember]
        public DateTime Date { get; set; } = DateTime.Now;

        [NotMapped]
        public bool ShouldExportSerie { get; set; }

        [NotMapped]
        public bool ShouldExportUser { get; set; }

        public bool ShouldSerializeSerie()
        {
            return ShouldExportSerie;
        }

        public bool ShouldSerializeUser()
        {
            return ShouldExportUser;
        }

        public override string ToString()
        {
            return "Note du "+Date.ToShortDateString() + " par " + User.Login +" pour "+Serie.Nom;
        }

    }
}
