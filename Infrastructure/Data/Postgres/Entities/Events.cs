using Infrastructure.Data.Postgres.Entities.Base;


namespace Infrastructure.Data.Postgres.Entities
{
    public class Events : Entity<int>
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }

        public int SportID { get; set; }        
        public int AdressID { get; set; }

        public Sports Sports { get; set; }
        public Adress Adress { get; set; }

        public IList<Point> Points { get; set; }
        public IList<Comment> Comments { get; set; }
        public IList<UserEvents> UserEvents { get; set; }
    }
}
