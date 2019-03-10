using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.Model.Models
{
    [Table("Pages")]
    public class Page:Auditable
    {
        [Key]
        [MaxLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [Required]
        public string content { set; get; }
    }
}
