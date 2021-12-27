using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;

namespace test_api.Models
{
    public static class DbInitialize
    {
        public static void INIT(IServiceProvider serviceProvider)
        {
            var context = new DBContext(
                serviceProvider.GetRequiredService<DbContextOptions<DBContext>>());
            context.Database.EnsureCreated();
            if (context.Users.Any())
            {
                return;
            }

            context.Users.AddRange(dummyUsers());
            context.SaveChanges();
        }

        public static IEnumerable<User> dummyUsers()
        {
            return new List<User>{
                new User{
                    
                    Name ="Nopawat",
                    Position ="Engineer"
                }
            };
        }
    }
}