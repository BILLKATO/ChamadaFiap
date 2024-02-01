using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamadaFiap.Entities;

public class Class
{
    [Key]
    public int Id { get; set; }
    public int TeacherId { get; set; }
    public int TeamId { get; set; }
    public string Name { get; set; }

    [ForeignKey("TeamId")]
    public virtual Team Team { get; set; }

    [ForeignKey("TeacherId")]
    public virtual Teacher Teacher { get; set; }
    public virtual ICollection<StudentClass> StudentClasses { get; set; }
    public virtual ICollection<ClassPeriod> ClassPeriods { get; set; }
}