using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess
{
    public class HotelDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-417F5ER\\SQLEXPRESS;Database=HotelDb;uid=sa;pwd=ronaldinyo1907;TrustServerCertificate=True");
        }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
