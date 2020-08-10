using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JL.Mini.Api.Model
{
    public class Context :DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Question> Questions { get; set; }
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
