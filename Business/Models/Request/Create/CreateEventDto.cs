using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CreateEventDto
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }

        public int SportID { get; set; }
        public int AdressID { get; set; }
    }
}
