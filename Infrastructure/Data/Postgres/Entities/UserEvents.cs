using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class UserEvents
    {
        [Key]
        public int UserEventsID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }

        public int EventID { get; set; }
        public Events Events { get; set; }


    }
}
