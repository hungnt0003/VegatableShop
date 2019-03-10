using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistics
    {
        [Key]
        [MaxLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public DateTime VisitorDate { set; get; }
        public string IPAddress { set; get; }
    }
}
