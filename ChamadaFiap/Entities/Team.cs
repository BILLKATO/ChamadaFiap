using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamadaFiap.Entities;

public class Team
{
    [Key]
    public int Id { get; set; }
    public int CourseId { get; set; }
    public string Name { get; set; }
    public DateTime? Start { get; set; }
    public DateTime? Finish { get; set; }

    [ForeignKey("CourseId")]
    public virtual Course Course { get; set; }
    public virtual ICollection<Student> Students { get; set; }
    public virtual ICollection<Class> Classes { get; set; }
}