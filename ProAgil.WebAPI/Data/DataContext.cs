using Microsoft.EntityFrameworkCore;
using ProAgil.WebAPI.Model;

namespace ProAgil.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base (options){}      


        // criação das tabelas no Banco
        public DbSet<Evento> Evento { get; set; }
    }
}