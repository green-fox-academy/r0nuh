using Microsoft.AspNetCore.Mvc;
using SayHello.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SayHello.Controllers
{
    [Route("hellos")]
    public class HellosController : Controller
    {   
        private static string[] hellos =
        { "Mirëdita", "Ahalan", "Parev", "Zdravei", "Nei Ho", "Dobrý den", "Ahoj", "Goddag", "Goede dag", "Hallo", "Hello", "Saluton", "Hei", "Bonjour",
          "Guten Tag", "Gia'sou", "Aloha", "Shalom", "Namaste", "Namaste", "Jó napot", "Halló", "Helló", "Góðan daginn", "Halo", "Aksunai", "Qanuipit", "Dia dhuit",
          "Salve", "Ciao", "Kon-nichiwa", "An-nyong Ha-se-yo", "Salvëte", "Ni hao", "Dzien' dobry", "Olá", "Bunã ziua", "Zdravstvuyte", "Hola", "Jambo", "Hujambo", "Hej",
          "Sa-wat-dee", "Merhaba", "Selam", "Vitayu", "Xin chào", "Hylo", "Sut Mae", "Sholem Aleychem", "Sawubona"
        };

        public IActionResult Hellos()
        {
            var greetings = new Hellos()
            {
                HelloArray = hellos
            };

            return View(greetings);
        }
    }
}
