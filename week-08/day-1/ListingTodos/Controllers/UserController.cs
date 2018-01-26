using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos.Models;
using ListingTodos.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ListingTodos.Controllers
{
    [Route("")]
    public class UserController : Controller
    {
        private TodoRepository todoRepository;

        public UserController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        [HttpGet("")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult AddUser(User user)
        {
            todoRepository.AddUser(user);
            return RedirectToAction("Login");
        }
    }
}
