using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamadaFiap.Entities;

public class Student
{
    [Key]
    public int Id { get; set; }
    public int TeamId { get; set; }
    public string Name { get; set; }
    public string RegisterEnrollment { get; set; }

    [ForeignKey("TeamId")]
    public virtual Team Team { get; set; }
    public virtual ICollection<StudentClass> Classes { get; set; }
}