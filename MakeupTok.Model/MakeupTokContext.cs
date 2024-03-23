using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MakeupTok.Model;

public class MakeupTokContext : DbContext
{

    /// <summary>
    /// Database path
    /// </summary>
    public string DbPath { get; }

    public DbSet<User> Users { get; set; }
    public DbSet<Makeup> Makeups { get; set; }
    public DbSet<MakeupStep> MakeupStep { get; set; }

    /// <summary>
    /// Default c-tor
    /// </summary>
    public MakeupTokContext()
    {
        var currentLocation = Assembly.GetExecutingAssembly();
        var path = Path.GetDirectoryName(currentLocation.Location);
        DbPath = Path.Join(path, "Data.db");
    }

    /// <summary>
    /// On configuring override
    /// </summary>
    /// <param name="options"></param>
    protected override async void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source={DbPath}");
    }

}