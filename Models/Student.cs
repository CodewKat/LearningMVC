﻿using System;
using System.Collections.Generic;

namespace ServiceBasedApplication.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
