﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SchoolAPI.Models
{
    [Table("Course")]
    public partial class Course
    {
        public Course()
        {
            CourseInstructors = new HashSet<CourseInstructor>();
            StudentGrades = new HashSet<StudentGrade>();
        }

        [Key]
        [Column("CourseID")]
        public int CourseId { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public int Credits { get; set; }
        [Column("DepartmentID")]
        public int DepartmentId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty("Courses")]
        public virtual Department Department { get; set; }
        [InverseProperty("Course")]
        public virtual OnlineCourse OnlineCourse { get; set; }
        [InverseProperty("Course")]
        public virtual OnsiteCourse OnsiteCourse { get; set; }
        [InverseProperty(nameof(CourseInstructor.Course))]
        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }
        [InverseProperty(nameof(StudentGrade.Course))]
        public virtual ICollection<StudentGrade> StudentGrades { get; set; }
    }
}
