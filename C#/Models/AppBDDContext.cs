using Microsoft.EntityFrameworkCore;

namespace OptativoTercerParcial.Models
{
    public class AppBDDContext : DbContext
    {
        public AppBDDContext(DbContextOptions<AppBDDContext> options) : base(options)
        {
        }

        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cuentas> Cuentas { get; set; }
        public DbSet<Movimientos> Movimientos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ciudad>()
                .HasKey(c => c.idCiudad);

            modelBuilder.Entity<Persona>()
                .HasKey(p => p.idPersona);

            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.idCliente);

            modelBuilder.Entity<Cuentas>()
                .HasKey(c => c.idCuenta);

            modelBuilder.Entity<Movimientos>()
                .HasKey(m => m.idMovimiento);
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Persona)
                .WithMany()
                .HasForeignKey(u => u.IDPERSONA);
        }
    }

}
