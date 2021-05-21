using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SchoolAPI.Models
{
    [Table("CourseInstructor")]
    public partial class CourseInstructor
    {
        [Key]
        [Column("CourseID")]
        public int CourseId { get; set; }
        [Key]
        [Column("PersonID")]
        public int PersonId { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty("CourseInstructors")]
        public virtual Course Course { get; set; }
        [ForeignKey(nameof(PersonId))]
        [InverseProperty("CourseInstructors")]
        public virtual Person Person { get; set; }
    }
}
