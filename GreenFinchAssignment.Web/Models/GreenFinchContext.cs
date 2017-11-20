using System;


using Microsoft.EntityFrameworkCore;
using GreenFinchAssignment.Web.Models;

namespace GreenFinchAssignment.DataStructure
{
    public class GreenFinchContext : DbContext
    {
        public GreenFinchContext(DbContextOptions<GreenFinchContext> options) : base(options) { }
        public DbSet<SubscribingSourceViewModel> SubscribingSource { get; set; }
        public DbSet<SubscribingUserViewModel> SubscribingUser { get; set; }
    }
}
