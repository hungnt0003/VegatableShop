using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        [MaxLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(50)]
        public string Code { set; get; }
        [Required]
        [MaxLength(50)]
        public string Value { set; get; }
    }
}
