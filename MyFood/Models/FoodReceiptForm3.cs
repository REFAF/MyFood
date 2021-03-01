using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class FoodReceiptForm3
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int f3_id { get; set; }

        public byte? car_num { get; set; }

        public byte? staff_num { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [StringLength(50)]
        public string day { get; set; }

        public byte? staff_health_status_type_id { get; set; }

        [StringLength(10)]
        public string note { get; set; }

        //public long? leader_id { get; set; }

        //public long? supervisor { get; set; }

        public Employee Employee { get; set; }
        public long Emp_id { get; set; }

    }
}