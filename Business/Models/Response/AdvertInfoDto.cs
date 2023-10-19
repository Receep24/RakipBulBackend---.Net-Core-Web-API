using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class AdvertInfoDto
    {
        public int Id { get; set; }
        public string AdvertText { get; set; }
        public int UserID { get; set; }
        public int SportID { get; set; }
        public int AdressID { get; set; }

        public AdressInfoDto Adress { get; set; }
        public SportsInfoDto Sport { get; set; }
        public UserProfileDto User { get; set; }
    }

    
    
}
