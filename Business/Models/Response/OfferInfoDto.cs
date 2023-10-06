using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class OfferInfoDto
    {
        public int Id { get; set; }
        public string OfferText { get; set; }
        public int AdvertID { get; set; }
        public int UserID { get; set; }
    }
}
