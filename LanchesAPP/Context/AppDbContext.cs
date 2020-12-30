using LanchesAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesAPP.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
