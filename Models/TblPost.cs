using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SchoolAPI.Models
{
    [Table("tblPosts")]
    public partial class TblPost
    {
        [Key]
        public int PostId { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        [StringLength(500)]
        public string Body { get; set; }
    }
}
