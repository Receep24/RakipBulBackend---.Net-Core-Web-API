using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CreateUserEvent
    {  
        public int UserEventsID { get; set; }
        public int UserID { get; set; }
        public int EventID { get; set; }
    }
}
