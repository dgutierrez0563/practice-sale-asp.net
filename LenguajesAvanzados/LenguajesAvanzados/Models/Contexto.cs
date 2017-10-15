namespace LenguajesAvanzados.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Contexto : DbContext
    {
        // Your context has been configured to use a 'Contexto' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'LenguajesAvanzados.Models.Contexto' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Contexto' 
        // connection string in the application configuration file.
        public Contexto()
            : base("name=Contexto")
        {
        }

        public System.Data.Entity.DbSet<LenguajesAvanzados.Models.Categoria> Categorias { get; set; }

        public System.Data.Entity.DbSet<LenguajesAvanzados.Models.Proveedor> Proveedors { get; set; }

        public System.Data.Entity.DbSet<LenguajesAvanzados.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<LenguajesAvanzados.Models.Vendedor> Vendedors { get; set; }

        public System.Data.Entity.DbSet<LenguajesAvanzados.Models.Producto> Productoes { get; set; }

        public System.Data.Entity.DbSet<LenguajesAvanzados.Models.Facturar> Facturars { get; set; }

        public System.Data.Entity.DbSet<LenguajesAvanzados.Models.Detalle> Detalles { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}