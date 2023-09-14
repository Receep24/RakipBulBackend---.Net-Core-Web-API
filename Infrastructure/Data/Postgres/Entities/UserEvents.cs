using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class UserEvents
    {
        
            public int UserID { get; set; }
            public User User { get; set; }

            public int EventID { get; set; }
            public Events Event { get; set; }
        

    }
}
