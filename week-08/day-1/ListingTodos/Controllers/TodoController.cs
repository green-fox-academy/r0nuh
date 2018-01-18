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
        public IActionResult List([FromQuery] bool isActive)
        {
            if (isActive == false)
                return View(todoRepository.ListAll());
            else
                return View(todoRepository.IsActive());
        }

        [HttpGet("add")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult AddTodo(Todo todo)
        {
            todoRepository.AddTodo(todo.Title);
            return RedirectToAction("List");
        }

        [HttpPost("{id}/delete")]
        public IActionResult Delete([FromQuery]long id)
        {
            todoRepository.Remove(id);
            return RedirectToAction("List");
        }

        [HttpGet("edit")]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost("edit")]
        public IActionResult Update(Todo todo)
        {
            todoRepository.Edit(todo);
            return RedirectToAction("List");
        }
    }
}
