using Microsoft.EntityFrameworkCore;
using MVCProject.Models;

namespace MVCProject.Data;

public class MVCContext: DbContext
{
    public MVCContext(DbContextOptions<MVCContext> options) : base(options) { }
    
    public DbSet<Item> Items { get; set; }
}