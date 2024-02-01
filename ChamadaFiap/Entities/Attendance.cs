using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamadaFiap.Entities;

public class Attendance
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }

    //public virtual ICollection<StudentClass> StudentClasses { get; set; }
}