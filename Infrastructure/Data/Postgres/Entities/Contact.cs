using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Contact:Entity<int>

    {
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;

        public int UserID { get; set; }
        public User User { get; set; }

    }
}
