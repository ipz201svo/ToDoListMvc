using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListMvc.Data;
using ToDoListMvc.Models;

namespace ToDoListMvc.Repositories
{
    public class GoalRepository : IGoalRepository
    {
        GoalContext context;
        DbSet<Goal> _dbSet;

        public GoalRepository(GoalContext context)
        {
            this.context = context;
            _dbSet = context.Set<Goal>();
        }

        public IList<Goal> Get()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IList<Goal> Get(Func<Goal, bool> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).ToList();
        }
        public Goal FindById(int? id)
        {
            return _dbSet.Find(id);
        }

        public void Create(Goal item)
        {
            _dbSet.Add(item);
            //context.SaveChanges();
        }
        public void Update(Goal item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Remove(Goal item)
        {
            _dbSet.Remove(item);
            context.SaveChanges();
        }
    }
}

