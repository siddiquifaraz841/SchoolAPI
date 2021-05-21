using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SchoolAPI.Models
{
    [Table("Organisation123")]
    public partial class Organisation123
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("pushSeqNo")]
        public long PushSeqNo { get; set; }
        [Required]
        [Column("hierarchyId")]
        [StringLength(20)]
        public string HierarchyId { get; set; }
        [Required]
        [Column("bpId")]
        [StringLength(10)]
        public string BpId { get; set; }
        [Required]
        [Column("bpType")]
        [StringLength(20)]
        public string BpType { get; set; }
        [Required]
        [Column("bpName")]
        [StringLength(160)]
        public string BpName { get; set; }
        [Column("parentBpId")]
        [StringLength(10)]
        public string ParentBpId { get; set; }
    }
}
