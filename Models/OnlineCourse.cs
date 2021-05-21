﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SchoolAPI.Models
{
    [Table("OnlineCourse")]
    public partial class OnlineCourse
    {
        [Key]
        [Column("CourseID")]
        public int CourseId { get; set; }
        [Required]
        [Column("URL")]
        [StringLength(100)]
        public string Url { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty("OnlineCourse")]
        public virtual Course Course { get; set; }
    }
}
