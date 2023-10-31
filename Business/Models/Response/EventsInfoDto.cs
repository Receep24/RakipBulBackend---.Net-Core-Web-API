using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class EventsInfoDto
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public int SportID { get; set; }
        public int AdressID { get; set; }

        public AdressInfoDto Adress { get; set; }
        public SportsInfoDto Sports { get; set; }
    }
}
