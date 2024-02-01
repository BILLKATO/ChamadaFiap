using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamadaFiap.Entities;

public class CourseSyllabus
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    [ForeignKey("ClassPeriodId")]
    public virtual ClassPeriod ClassPeriod { get; set; }
}