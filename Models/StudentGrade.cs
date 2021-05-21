using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SchoolAPI.Models
{
    [Table("StudentGrade")]
    public partial class StudentGrade
    {
        [Key]
        [Column("EnrollmentID")]
        public int EnrollmentId { get; set; }
        [Column("CourseID")]
        public int CourseId { get; set; }
        [Column("StudentID")]
        public int StudentId { get; set; }
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? Grade { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty("StudentGrades")]
        public virtual Course Course { get; set; }
        [ForeignKey(nameof(StudentId))]
        [InverseProperty(nameof(Person.StudentGrades))]
        public virtual Person Student { get; set; }
    }
}
