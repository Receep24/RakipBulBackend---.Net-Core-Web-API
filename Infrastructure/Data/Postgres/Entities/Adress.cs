using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Adress:Entity<int>
    {  
        public string AdressName { get; set; }

        public int CityId { get; set; }
        public int DistrictId { get; set; }       
        
        public Cities City { get; set; }
        public Districts District { get; set; }

        public IList<Events> Events { get; set; }
        public IList<Advert> Adverts { get; set; }
    }
}
