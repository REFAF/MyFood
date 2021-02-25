using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class OrderForm1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int order_id { get; set; }

        [StringLength(50)]
        public string day { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] occasion_time { get; set; }

        public byte? persons_num { get; set; }

        public string location { get; set; }

        public byte? buffet_type_id { get; set; }

        public BuffetType BuffetType { get; set; }
    }
}