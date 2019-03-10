using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.Model.Models
{
    [Table("SupportOnlines")]
    class SupportOnline
    {
        [Key]
        [MaxLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }
        [MaxLength(50)]
        public string Department { set; get; }
        [MaxLength(50)]
        public string Skype { set; get; }
        [MaxLength(50)]
        public string Tel { set; get; }
        [MaxLength(50)]
        public string Email { set; get; }
        [MaxLength(50)]
        public string Yahoo { set; get; }
        [MaxLength(50)]
        public string Facebook { set; get; }
        public int?DisplayOrder { set; get; }
        public bool? Status { set; get; }
    }
}
