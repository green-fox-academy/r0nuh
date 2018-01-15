using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos.Models;
using ListingTodos.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ListingTodos.Controlls
{
    [Route("todo")]
    public class TodoController : Controller
    {
        private TodoRepository todoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        [HttpGet("")]
        [Route("list")]
        public IActionResult List()
        {
            List<Todo> TodoList = new List<Todo>()
            {
               //new Todo() {Title = "Start the day" },
               //new Todo() {Title = "Create CRUD project" }
            };

            return View(TodoList);
        }
    }
}
