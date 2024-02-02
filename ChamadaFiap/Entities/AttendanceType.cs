using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamadaFiap.Entities;

public class AttendanceType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Attendance>? Attendances { get; set; }
}