using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamadaFiap.Entities;

public class Attendance
{
    public int Id { get; set; }
    public DateTime? Start { get; set; }
    public DateTime? Finish { get; set; }
    public virtual ClassPeriod ClassPeriod { get; set; }
    public int ClassPeriodId { get; set; }
    public virtual Student Student { get; set; }
    public int StudentId { get; set; }
    public virtual AttendanceType AttendanceType { get; set; }
    public int AttendanceTypeId { get; set; }
}