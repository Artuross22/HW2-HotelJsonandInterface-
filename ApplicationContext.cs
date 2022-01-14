using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelJsonandInterface.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelJsonandInterface
{


    public class ApplicationContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }

        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = Delite3 SqlStorageProvider; Trusted_Connection = True; MultipleActiveResultSets = true");
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
    }
}
