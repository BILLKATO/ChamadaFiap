using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamadaFiap.Entities;

public class StudentClass
{
    [Key]
    public int Id { get; set; }
    public int ClassId { get; set; }
    public int StudentId { get; set; }
    public int AttendanceId { get; set; }
    public DateTime? Start { get; set; }
    public DateTime? Finish { get; set; }

    [ForeignKey("ClassId")]
    public virtual Class Class { get; set; }

    [ForeignKey("StudentId")]
    public virtual Student Student { get; set; }

    [ForeignKey("AttendanceId")]
    public virtual Attendance Attendance { get; set; }
}