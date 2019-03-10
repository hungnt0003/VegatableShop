﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.Model.Models
{
    [Table("Posts")]
    public class Post:Auditable
    {
        [Key]
        [MaxLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        [Required]
        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        public string Alias { set; get; }
        [Required]
        public int? CategoryId { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        [MaxLength(500)]
        public String Desciption { set; get; }
        public string Content { set; get; }

        [ForeignKey("CategoryId")]
        public virtual PostCategory PostCategory { set; get; }
    }
}
