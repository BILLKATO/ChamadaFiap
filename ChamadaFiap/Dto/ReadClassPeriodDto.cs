using ChamadaFiap.Entities;

namespace ChamadaFiap.Dto
{
    public class ReadClassPeriodDto
    {
        public DateTime StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public ReadClassDto Class { get; set; }
        public bool IsCourseSyllabusOk { get { return CourseSyllabus is not null && CourseSyllabus.Count > 0; } }
        public virtual ICollection<CourseSyllabus>? CourseSyllabus { get; set; }
    }
}
