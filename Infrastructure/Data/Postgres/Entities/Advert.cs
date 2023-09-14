using Infrastructure.Data.Postgres.Entities.Base;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Advert : Entity<int>
    {
        public string AdvertText { get; set; }


        public int UserID { get; set; }
        public int SportID { get; set; }
        public int AdressID { get; set; }
        

        public User User { get; set; }
        public Sports Sport { get; set; }
        public Adress Adress { get; set; }
       

        public IList<Offer> Offers { get; set; }




    }
}
