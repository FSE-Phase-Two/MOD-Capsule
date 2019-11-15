using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MOD.DATA.Model;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace MOD.DATA
{
   public class MODContext : DbContext
    {
        public MODContext(DbContextOptions<MODContext> options)
           : base(options)
        {
        }
        public DbSet<Technology> Technology { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Mentor> Mentor { get; set; }
        public DbSet<MentorTechnology> MentorTechnology { get; set; }
        public DbSet<MentorCalender> MentorCalender { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Payment> Payment { get; set; }
    }
}
