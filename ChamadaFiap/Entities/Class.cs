using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamadaFiap.Entities;

public class Class
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual Team Team { get; set; }
    public int TeamId { get; set; }
    public virtual Teacher Teacher { get; set; }
    public int TeacherId { get; set; }
    public virtual Subject Subject { get; set; }
    public int SubjectId { get; set; }
    public virtual ICollection<ClassPeriod>? ClassPeriods { get; set; }
}