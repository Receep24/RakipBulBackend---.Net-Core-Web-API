using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class AdvertUpdateDTO
    {
        public string AdvertText { get; set; }
        public int UserID { get; set; }
        public int SportID { get; set; }
        public int AdressID { get; set; }
    }
}
