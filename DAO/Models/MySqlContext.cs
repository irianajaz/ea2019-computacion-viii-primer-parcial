using Microsoft.EntityFrameworkCore;

namespace DAO.Models
{
    public class MySqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;user=tambos;password=123654;database=tambos;port=3306");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol>(rol => {
                rol.HasIndex(r => r.Nombre).IsUnique();
                rol.HasMany(r => r.Permisos).WithOne(p => p.Rol);
                rol.HasMany(r => r.Usuarios).WithOne(u => u.Rol);
            });

            modelBuilder.Entity<Permiso>(permiso => {
                permiso.HasIndex(p => p.Nombre).IsUnique();
                permiso.HasOne(p => p.Rol).WithMany(r => r.Permisos);
            });

            modelBuilder.Entity<Usuario>(usuario => {
                usuario.HasIndex(u => u.Nombre).IsUnique();
                usuario.HasIndex(u => u.CorreoElectronico).IsUnique();
                usuario.HasOne(p => p.Rol).WithMany(r => r.Usuarios);
            });
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Rol> Roles { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}