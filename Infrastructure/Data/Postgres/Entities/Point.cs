using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Point : Entity<int>
    {
        public int Points { get; set; }

        public int UserID {get;set;}
        public int EventID {get;set; }

        public User User { get; set; }
        public Events Events { get; set; }
    }
}
