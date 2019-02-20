namespace ConsoleApp4
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class dbq : DbContext
    {
        // Your context has been configured to use a 'dbq' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ConsoleApp4.dbq' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'dbq' 
        // connection string in the application configuration file.
        public dbq()
            : base("name=dbq")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet <AbstractProduct> AbstractProducts { get; set; }
        public virtual DbSet <Adress> Adresses { get; set; }
        public virtual DbSet <Building> Buildings { get; set; }
        public virtual DbSet <Category> Categories { get; set; }
        public virtual DbSet <Country> Countries { get; set; }
        public virtual DbSet <Gender> Genders { get; set; }
        public virtual DbSet <Order> Orders { get; set; }
        public virtual DbSet <Producer> Producers { get; set; }
        public virtual DbSet <RealProduct> RealProducts { get; set; }
        public virtual DbSet <Status> Statuses { get; set; }
        public virtual DbSet <User> Users { get; set; }
    }
}