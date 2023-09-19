using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class UserEventsDto
    {
        public int Id { get; set; }
        public IList<Events> ParticipatedEvents { get; set; }
    }
}
