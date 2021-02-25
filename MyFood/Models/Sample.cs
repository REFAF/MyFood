using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Sample
    {
        [Key]
        public int sample_id { get; set; }

        public short? product_id { get; set; }

        public int? input_order_id { get; set; }

        public DateTime? sample_datetime { get; set; }

        public short? wheight { get; set; }
    }
}