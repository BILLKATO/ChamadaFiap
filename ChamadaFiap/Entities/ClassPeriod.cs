using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamadaFiap.Entities;

public class ClassPeriod
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? FinishTime { get; set; }
    public virtual Class Class { get; set; }
    public int ClassId { get; set; }
    public bool IsCourseSyllabusOk { get { return CourseSyllabus is not null &&  CourseSyllabus.Count > 0; } }
    public virtual ICollection<CourseSyllabus>? CourseSyllabus { get; set; }
    public virtual ICollection<Attendance>? Attendances { get; set; }

}