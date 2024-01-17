using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using WebAPINET8.Models;

namespace WebAPINET8.Database
{
    public class ApplicationDbContext : DbContext
    { 
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empresa> Empresas { get; set; }




        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            //try
            //{
            //    var dbCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;

            //    if (dbCreator != null)
            //    {
            //        if (!dbCreator.CanConnect())
            //            dbCreator.Create();
            //        if (!dbCreator.HasTables())
            //            dbCreator.CreateTables();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración y seeding de usuarios
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { UsuarioId = 1, Nombre = "Usuario1", CorreoElectronico = "usuario1@example.com", EmpresaId = 1 },
                new Usuario { UsuarioId = 2, Nombre = "Usuario2", CorreoElectronico = "usuario2@example.com", EmpresaId = 1 },
                new Usuario { UsuarioId = 3, Nombre = "Usuario3", CorreoElectronico = "usuario3@example.com", EmpresaId = 1 },
                new Usuario { UsuarioId = 4, Nombre = "Usuario4", CorreoElectronico = "usuario4@example.com", EmpresaId = 1 },
                new Usuario { UsuarioId = 5, Nombre = "Usuario5", CorreoElectronico = "usuario5@example.com", EmpresaId = 1 },
                new Usuario { UsuarioId = 6, Nombre = "Usuario6", CorreoElectronico = "usuario6@example.com", EmpresaId = 2 },
                new Usuario { UsuarioId = 7, Nombre = "Usuario7", CorreoElectronico = "usuario7@example.com", EmpresaId = 2 },
                new Usuario { UsuarioId = 8, Nombre = "Usuario8", CorreoElectronico = "usuario8@example.com", EmpresaId = 2 },
                new Usuario { UsuarioId = 9, Nombre = "Usuario9", CorreoElectronico = "usuario9@example.com", EmpresaId = 2 },
                new Usuario { UsuarioId = 10, Nombre = "Usuario10", CorreoElectronico = "usuario10@example.com", EmpresaId = 2 }
            );

            // Configuración y seeding de empresas
            modelBuilder.Entity<Empresa>().HasData(
                new Empresa { EmpresaId = 1, Nombre = "Empresa1", Direccion = "Dirección1" },
                new Empresa { EmpresaId = 2, Nombre = "Empresa2", Direccion = "Dirección2" }
            // Puedes añadir más empresas según sea necesario
            );


            // Relación uno a muchos entre Empresa y Usuario
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Empresa)
                .WithMany(e => e.Usuarios)
                .HasForeignKey(u => u.EmpresaId);


        }
    }
}
