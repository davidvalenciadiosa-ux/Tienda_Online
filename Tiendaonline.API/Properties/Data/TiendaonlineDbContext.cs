using Microsoft.EntityFrameworkCore;
using Tiendaonline.API.Models;

namespace Tiendaonline.API.Data
{
    public class TiendaonlineDbContext :DbContext
    {
        public TiendaonlineDbContext(DbContextOptions<TiendaonlineDbContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
    
    }
}
