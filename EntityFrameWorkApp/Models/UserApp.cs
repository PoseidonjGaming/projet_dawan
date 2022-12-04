using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkApp.Models;

[Table("userApp")]
public partial class UserApp
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("login")]
    [StringLength(255)]
    [Unicode(false)]
    public string Login { get; set; } = null!;

    [Column("password")]
    [StringLength(255)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [InverseProperty("UserApp")]
    public virtual ICollection<UserRole> UserRoles { get; } = new List<UserRole>();
}
