using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Events : Entity<int>
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public int SportID { get; set; }
        public int UserID { get; set; }
        public int AdressID { get; set; }

        public Sports Sports { get; set; }
        public User User { get; set; }
        public Adress Adress { get; set; }

        public IList<Point> Points { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
