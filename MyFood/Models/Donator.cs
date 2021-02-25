using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Donator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long donator_id { get; set; }

        [StringLength(30)]
        public string name { get; set; }

        [StringLength(10)]
        public string mobile { get; set; }
        public City City { get; set; }

        public byte? city_id { get; set; }
    }
}