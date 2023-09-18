using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class UserAdvertsDto
    {
        public int Id { get; set; }
        public IList<Advert> Adverts { get; set; }
    }
}
