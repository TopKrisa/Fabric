using System.ComponentModel.DataAnnotations;

namespace Fabric.DAL.Abstractions.Model;

public class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
}