using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Sports:Entity<int>
    {
        public string SportName { get; set; }
        public string SportImage { get; set; }

        public IList<Events> Events { get; set; }   
        public IList<Advert> Adverts { get; set; }

    }
}
