using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace SerieDLL_EF.Models;

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
    public string ToWatch { get; set; } = "{}";

    [DataMember]
    [NotMapped]
    public List<int> ToWatchList { get; set; } = new List<int>();

    [NotMapped]
    public List<Note> Notes { get; set; } = new List<Note>();

    public void SetToWatchList(List<Serie> list)
    {
        foreach (Serie serie in list)
        {
            ToWatchList.Add(serie.Id);
        }
        ToWatch = JsonConvert.SerializeObject(ToWatchList);
    }

    public void UnsetToWatchlist(List<Serie> list)
    {
        foreach (Serie serie in list)
        {
            ToWatchList.Remove(serie.Id);
        }
        ToWatch = JsonConvert.SerializeObject(ToWatchList);
    }

    public bool IsGranted(Roles role)
    {
        return this.Roles >= role;
    }

    public override bool Equals(object? obj)
    {
        UserApp user = (UserApp)obj;
        return Login == user.Login && Password == user.Password;
    }



}
