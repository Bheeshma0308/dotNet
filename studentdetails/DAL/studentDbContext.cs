using Microsoft.EntityFrameworkCore;
using studentdetails.Models.DBEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentdetails.DAL
{
    public class studentDbContext : DbContext
    {
        public studentDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> students { get; set; }
    }
}
