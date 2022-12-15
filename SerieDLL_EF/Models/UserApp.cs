using SerieDLL_EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace projet_dawan.Models;

[Serializable]
[DataContract]
public partial class UserApp
{
    [DataMember]
    public int Id { get; set; }

    [DataMember]
    public string Login { get; set; } = null!;

    [DataMember]
    public string Password { get; set; } = null!;

   

    [DataMember]
    public Roles Roles { get; set; }


    [DataMember]
    [NotMapped]
    public List<int> ToWatch { get; set; } = new List<int>();

    public void SetToWatch(List<Serie> list)
    {
        foreach(Serie serie in list)
        {
            ToWatch.Add(serie.Id);
        }
    }
}
