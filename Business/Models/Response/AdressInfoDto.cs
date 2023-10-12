using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class AdressInfoDto
    {
        public int Id { get; set; }
        public string AdressName { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        
        

        public DistrictsInfoDto District { get; set; }
        public CitiesInfoDto City { get; set; }

    }
}
