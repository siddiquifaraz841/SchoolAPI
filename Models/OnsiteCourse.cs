using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SchoolAPI.Models
{
    [Table("OnsiteCourse")]
    public partial class OnsiteCourse
    {
        [Key]
        [Column("CourseID")]
        public int CourseId { get; set; }
        [Required]
        [StringLength(50)]
        public string Location { get; set; }
        [Required]
        [StringLength(50)]
        public string Days { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime Time { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty("OnsiteCourse")]
        public virtual Course Course { get; set; }
    }
}
