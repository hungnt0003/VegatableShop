﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [MaxLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Required]
        [MaxLength(256)]
        public string Description { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }
        [Required]
        [MaxLength(256)]
        public string URL { set; get; }
        public int? DisplayOrder { set; get; }
        public bool? Status { set; get; }
    }
}
