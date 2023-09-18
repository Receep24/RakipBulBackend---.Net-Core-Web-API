using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class ShowAdvertsDto
    {
        public string AdvertText { get; set; }
        public int UserID { get; set; }
        public int SportID { get; set; }
        public int AdressID { get; set; }
        public IList<Offer> Offers { get; set; }
    }
}
