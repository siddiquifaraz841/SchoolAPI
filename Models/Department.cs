﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SchoolAPI.Models
{
    [Table("Department")]
    public partial class Department
    {
        public Department()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        [Column("DepartmentID")]
        public int DepartmentId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        public int? Administrator { get; set; }

        [InverseProperty(nameof(Course.Department))]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
