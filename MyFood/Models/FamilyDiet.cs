using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class FamilyDiet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int family_diet_id { get; set; }

        public long ben_id { get; set; }

        public byte? person_num { get; set; }

        public byte? diet1_id { get; set; }

        public byte? diet2_id { get; set; }

        public byte? diet3_id { get; set; }

        public byte? diet4_id { get; set; }

        public byte? diet5_id { get; set; }

        public byte? diet6_id { get; set; }

        public byte? diet7_id { get; set; }

        public byte? diet8_id { get; set; }

        public byte? diet9_id { get; set; }

        public byte? diet10_id { get; set; }

        public Beneficiary Beneficiary { get; set; }

        public Diet Diet { get; set; }
    }
}