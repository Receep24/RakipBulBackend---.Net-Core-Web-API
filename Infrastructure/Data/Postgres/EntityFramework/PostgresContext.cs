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
        
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new UserTokenConfiguration());
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
    public DbSet<Contact> Contact => Set<Contact>();
    public DbSet<Districts> Districts => Set<Districts>();
    public DbSet<Events> Events => Set<Events>();
    public DbSet<Offer> Offer => Set<Offer>();
    public DbSet<Point> Point => Set<Point>();
    public DbSet<Sports> Sports => Set<Sports>();
    public DbSet<User> User => Set<User>();
    public DbSet<UserToken> UserTokens => Set<UserToken>();
}