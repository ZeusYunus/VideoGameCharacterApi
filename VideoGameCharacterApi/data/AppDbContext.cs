using Microsoft.EntityFrameworkCore;
using VideoGameCharacterApi.Models;

namespace VideoGameCharacterApi.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    // DbSet = Table; <Character> = Model; Characters = name of table
    public DbSet<Character> Characters => Set<Character>();
}