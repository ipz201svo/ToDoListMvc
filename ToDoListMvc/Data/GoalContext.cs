using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoListMvc.Models;

namespace ToDoListMvc.Data
{
    public class GoalContext : DbContext
    {
        public GoalContext(DbContextOptions<GoalContext> options)
            : base(options)
        {
        }

        public DbSet<Goal> Goals { get; set; }
    }
}
