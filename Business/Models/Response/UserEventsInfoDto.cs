using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class UserEventsInfoDto
    {
        public int UserID { get; set; }
        public int EventID { get; set; }
        public UserProfileDto User { get; set; }
        public EventsInfoDto Events { get; set; }
        
    }
}
