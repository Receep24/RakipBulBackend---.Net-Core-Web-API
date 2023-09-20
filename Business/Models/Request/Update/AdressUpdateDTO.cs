using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class AdressUpdateDTO
    {
        public string AdressName { get; set; }

        public int CityId { get; set; }
        public int DistrictId { get; set; }
    }
}
