using System.ComponentModel.DataAnnotations;

namespace ChamadaFiap.Entities;

public class Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public virtual ICollection<Class>? Classes { get; set; }
}