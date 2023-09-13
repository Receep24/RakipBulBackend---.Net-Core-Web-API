using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Cities
    {
        public int CityId { get; set; }
        public string CityName { get; set; }

        public IList<Adress> Addresses { get; set; } 
        public IList<Districts> Districts { get; set; }
    }


}
