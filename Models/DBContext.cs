using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace test_api.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options){

        }
        public DbSet<User> Users { get; set; }

        public List<User> getUsers()=> Users.ToList<User>();
    }
}
 