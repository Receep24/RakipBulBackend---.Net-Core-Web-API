using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Infrastructure.Data.Postgres.EntityFramework;

public class PostgresContext : DbContext
{
    private readonly IConfiguration _configuration;

    public PostgresContext(DbContextOptions<PostgresContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new AdressConfiguration());
        modelBuilder.ApplyConfiguration(new AdvertConfiguration());
        modelBuilder.ApplyConfiguration(new CitiesConfiguration());
        modelBuilder.ApplyConfiguration(new CommentConfiguration());
        modelBuilder.ApplyConfiguration(new DistrictsConfiguration());
        modelBuilder.ApplyConfiguration(new EventsConfiguration());
        modelBuilder.ApplyConfiguration(new OfferConfiguration());
        modelBuilder.ApplyConfiguration(new PointConfiguration());
        modelBuilder.ApplyConfiguration(new SportsConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new UserTokenConfiguration());
        modelBuilder.ApplyConfiguration(new UserEventsConfiguration());

        modelBuilder.Entity<Cities>().HasData(
              new Cities { CityId = 1, CityName = "Adana" },
              new Cities { CityId = 2, CityName = "Adıyaman" },
              new Cities { CityId = 3, CityName = "Afyonkarahisar" },
              new Cities { CityId = 4, CityName = "Ağrı" },
              new Cities { CityId = 5, CityName = "Amasya" },
              new Cities { CityId = 6, CityName = "Ankara" },
              new Cities { CityId = 7, CityName = "Antalya" },
              new Cities { CityId = 8, CityName = "Artvin" },
              new Cities { CityId = 9, CityName = "Aydın" },
              new Cities { CityId = 10, CityName = "Balıkesir" },
              new Cities { CityId = 11, CityName = "Bilecik" },
              new Cities { CityId = 12, CityName = "Bingöl" },
              new Cities { CityId = 13, CityName = "Bitlis" },
              new Cities { CityId = 14, CityName = "Bolu" },
              new Cities { CityId = 15, CityName = "Burdur" },
              new Cities { CityId = 16, CityName = "Bursa" },
              new Cities { CityId = 17, CityName = "Çanakkale" },
              new Cities { CityId = 18, CityName = "Çankırı" },
              new Cities { CityId = 19, CityName = "Çorum" },
              new Cities { CityId = 20, CityName = "Denizli" },
              new Cities { CityId = 21, CityName = "Diyarbakır" },
              new Cities { CityId = 22, CityName = "Edirne" },
              new Cities { CityId = 23, CityName = "Elazığ" },
              new Cities { CityId = 24, CityName = "Erzincan" },
              new Cities { CityId = 25, CityName = "Erzurum" },
              new Cities { CityId = 26, CityName = "Eskişehir" },
              new Cities { CityId = 27, CityName = "Gaziantep" },
              new Cities { CityId = 28, CityName = "Giresun" },
              new Cities { CityId = 29, CityName = "Gümüşhane" },
              new Cities { CityId = 30, CityName = "Hakkari" },
              new Cities { CityId = 31, CityName = "Hatay" },
              new Cities { CityId = 32, CityName = "Isparta" },
              new Cities { CityId = 33, CityName = "Mersin" },
              new Cities { CityId = 34, CityName = "Istanbul" },
              new Cities { CityId = 35, CityName = "Izmir" },
              new Cities { CityId = 36, CityName = "Kars" },
              new Cities { CityId = 37, CityName = "Kastamonu" },
              new Cities { CityId = 38, CityName = "Kayseri" },
              new Cities { CityId = 39, CityName = "Kırklareli" },
              new Cities { CityId = 40, CityName = "Kırşehir" },
              new Cities { CityId = 41, CityName = "Kocaeli" },
              new Cities { CityId = 42, CityName = "Konya" },
              new Cities { CityId = 43, CityName = "Kütahya" },
              new Cities { CityId = 44, CityName = "Malatya" },
              new Cities { CityId = 45, CityName = "Manisa" },
              new Cities { CityId = 46, CityName = "Kahramanmaraş" },
              new Cities { CityId = 47, CityName = "Mardin" },
              new Cities { CityId = 48, CityName = "Muğla" },
              new Cities { CityId = 49, CityName = "Muş" },
              new Cities { CityId = 50, CityName = "Nevşehir" },
              new Cities { CityId = 51, CityName = "Niğde" },
              new Cities { CityId = 52, CityName = "Ordu" },
              new Cities { CityId = 53, CityName = "Rize" },
              new Cities { CityId = 54, CityName = "Sakarya" },
              new Cities { CityId = 55, CityName = "Samsun" },
              new Cities { CityId = 56, CityName = "Siirt" },
              new Cities { CityId = 57, CityName = "Sinop" },
              new Cities { CityId = 58, CityName = "Sivas" },
              new Cities { CityId = 59, CityName = "Tekirdağ" },
              new Cities { CityId = 60, CityName = "Tokat" },
              new Cities { CityId = 61, CityName = "Trabzon" },
              new Cities { CityId = 62, CityName = "Tunceli" },
              new Cities { CityId = 63, CityName = "Şanlıurfa" },
              new Cities { CityId = 64, CityName = "Uşak" },
              new Cities { CityId = 65, CityName = "Van" },
              new Cities { CityId = 66, CityName = "Yozgat" },
              new Cities { CityId = 67, CityName = "Zonguldak" },
              new Cities { CityId = 68, CityName = "Aksaray" },
              new Cities { CityId = 69, CityName = "Bayburt" },
              new Cities { CityId = 70, CityName = "Karaman" },
              new Cities { CityId = 71, CityName = "Kırıkkale" },
              new Cities { CityId = 72, CityName = "Batman" },
              new Cities { CityId = 73, CityName = "Şırnak" },
              new Cities { CityId = 74, CityName = "Bartın" },
              new Cities { CityId = 75, CityName = "Ardahan" },
              new Cities { CityId = 76, CityName = "Iğdır" },
              new Cities { CityId = 77, CityName = "Yalova" },
              new Cities { CityId = 78, CityName = "Karabük" },
              new Cities { CityId = 79, CityName = "Kilis" },
              new Cities { CityId = 80, CityName = "Osmaniye" },
              new Cities { CityId = 81, CityName = "Düzce" }
              );
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        if (_configuration["EnvironmentAlias"] == "DEV")
        {
            optionsBuilder.LogTo(Console.Write);
        }
    }

    public DbSet<Adress> Adress => Set<Adress>();
    public DbSet<Advert> Advert => Set<Advert>();
    public DbSet<Cities> Cities => Set<Cities>();
    public DbSet<Comment> Comment => Set<Comment>();
    public DbSet<Districts> Districts => Set<Districts>();
    public DbSet<Events> Events => Set<Events>();
    public DbSet<Offer> Offer => Set<Offer>();
    public DbSet<Point> Point => Set<Point>();
    public DbSet<Sports> Sports => Set<Sports>();
    public DbSet<User> User => Set<User>();
    public DbSet<UserToken> UserTokens => Set<UserToken>();
    public DbSet<UserEvents> UserEvents => Set<UserEvents>();

}