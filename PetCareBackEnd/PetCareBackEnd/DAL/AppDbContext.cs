using Microsoft.EntityFrameworkCore;
using PetCareBackEnd.Models;

namespace PetCareBackEnd.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Slider> Slider { get; set; }
    }
}
