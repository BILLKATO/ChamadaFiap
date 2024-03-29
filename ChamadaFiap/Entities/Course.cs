﻿using System.ComponentModel.DataAnnotations;

namespace ChamadaFiap.Entities;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Team>? Teams { get; set; }
    public virtual ICollection<Subject>? Subjects { get; set; }
}