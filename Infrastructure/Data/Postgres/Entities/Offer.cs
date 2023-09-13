using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Offer:Entity<int>
    {
        public string OfferText { get; set; }

        public int AdvertID { get; set; }
        public int UserID { get; set; }

        public Advert Advert { get; set; }
        public User User { get; set; }  

    }
}
