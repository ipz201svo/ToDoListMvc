using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToDoListMvc.Data;
using ToDoListMvc.Models;
using ToDoListMvc.Repositories;

namespace ToDoListMvc.Controllers
{
    public class GoalsController : Controller
    {
        private IGoalRepository goalRepository;

        public GoalsController(IGoalRepository goalRepository)
        {
            this.goalRepository = goalRepository;
        }

        // GET: Goals
        public IActionResult Index()
        {
            return View(goalRepository.Get());
        }

        

        // POST: Goals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Goal goal)
        {
            if (ModelState.IsValid)
            {
                goalRepository.Create(goal);
                goalRepository.Update(goal);
            }
                return RedirectToAction("Index");
        }

        // GET: Goals/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var goal = goalRepository.FindById(id);
            if (goal == null)
            {
                return NotFound();
            }
            return View(goal);
        }

        // POST: Goals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Goal goal)
        {

            if (id != goal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                goalRepository.Update(goal);
                return RedirectToAction(nameof(Index));
            }
            return View(goal);
        }

        // GET: Goals/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goal = goalRepository.FindById(id);
            
            if (goal == null)
            {
                return NotFound();
            }
            goalRepository.Remove(goal);
            return RedirectToAction(nameof(Index));
            
        }

        //// POST: Goals/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public IActionResult DeleteConfirmed(int? id)
        //{
        //    var goal = goalRepository.FindById(id);
        //    //var goal = await context.Goal.FindAsync(id);
        //    //context.Goal.Remove(goal);
        //    goalRepository.Remove(goal);
        //    goalRepository.Update(goal);
        //    //await context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
    }
}

