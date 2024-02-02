using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamadaFiap.Entities;

public class CourseSyllabus
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ClassPeriod ClassPeriod { get; set; }
    public int ClassPeriodId { get; set; }
}