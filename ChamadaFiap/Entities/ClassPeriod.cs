using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamadaFiap.Entities;

public class ClassPeriod
{
    [Key]
    public int Id { get; set; }
    public int CourseSyllabusId { get; set; }
    public int ClassId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? FinishTime { get; set; }
    public virtual ICollection<CourseSyllabus> CourseSyllabus { get; set; }

    [ForeignKey("ClassId")]
    public virtual Class Class { get; set; }
}