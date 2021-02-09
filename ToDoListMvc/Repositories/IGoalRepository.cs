using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListMvc.Models;

namespace ToDoListMvc.Repositories
{
    public interface IGoalRepository
    {
        void Create(Goal item);
        Goal FindById(int? id);
        IList<Goal> Get();
        IList<Goal> Get(Func<Goal, bool> predicate);
        void Remove(Goal item);
        void Update(Goal item);
    }
}
