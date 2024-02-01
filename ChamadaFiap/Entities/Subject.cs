﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChamadaFiap.Entities;

public class Subject
{
    [Key]
    public int Id { get; set; }
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    [ForeignKey("CourseId")]
    public virtual Course Course { get; set; }
}