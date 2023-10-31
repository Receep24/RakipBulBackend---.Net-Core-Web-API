using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class UpdateCitiesDto
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
    }
}
