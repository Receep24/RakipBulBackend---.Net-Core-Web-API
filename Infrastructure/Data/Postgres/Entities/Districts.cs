

namespace Infrastructure.Data.Postgres.Entities
{
    public class Districts
    {
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }

        public int CityId { get; set; }
        public Cities City { get; set; }
        public IList<Adress> Addresses { get; set; }
    }
}
