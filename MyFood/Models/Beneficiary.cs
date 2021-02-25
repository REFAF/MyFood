using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Beneficiary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ben_id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? mobile { get; set; }

        public byte? city_id { get; set; }

        public string address { get; set; }

        public byte? sector_id { get; set; }

        public string location { get; set; }

        [StringLength(50)]
        public string guardian { get; set; }

        public byte? family_number { get; set; }
    }
}