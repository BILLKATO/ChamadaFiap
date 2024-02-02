using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamadaFiap.Entities;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string RegisterEnrollment { get; set; }
    public virtual Team Team { get; set; }
    public int TeamId { get; set; }
    public virtual ICollection<Attendance>? Attendances { get; set; }
}