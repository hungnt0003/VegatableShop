using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace V.Model.Models
{
    [Table("Orders")]
    public class Order : Auditable
    {
        [Key]
        [MaxLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(100)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddres { set; get; }

        [Required]
        [MaxLength(100)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(20)]
        public string CustomerTel { set; get; }
        [MaxLength(256)]
        public string CustomerMess { set; get; }

        [MaxLength(256)]
        public string PaymentMethod { set; get; }
        public string PaymentStatus { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}