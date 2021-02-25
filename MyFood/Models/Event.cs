using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyFood.Models
{
    public class Event
    {
        [Key]
        public long event_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? event_date { get; set; }

        public TimeSpan? event_time { get; set; }

        public DateTime? reg_date { get; set; }

        public byte? orgType_id { get; set; }

        [StringLength(50)]
        public string org_name { get; set; }

        public byte? buffet_type_id { get; set; }

        public int? persons_num { get; set; }

        public int? plate_num { get; set; }

        public DateTime? regdate { get; set; }
    }
}