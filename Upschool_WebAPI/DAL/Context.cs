using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Upschool_WebAPI.DAL.Entities;

namespace Upschool_WebAPI.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GTA587B\\SQLEXPRESS;initial catalog=UpSchoolApi;integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
