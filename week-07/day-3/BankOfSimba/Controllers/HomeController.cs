using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        public static List<BankAccount> BankAccounts = new List<BankAccount>()
        {
            new BankAccount("Pumbaa", 100, "Warthog"),
            new BankAccount("Timon", 250, "Meerkat"),
            new BankAccount("Rafiki", 1500, "Baboon"),
            new BankAccount("Zazu", 456, "Red-billed Hornbill")
        };

        [Route("Simba")]
        public IActionResult Index()
        {
            var bankAcc = new BankAccount("Simba", 2000, "Lion")
            {
                King = true
            };
            BankAccounts.Add(bankAcc);

            return View(bankAcc);
        }

        [Route("bank")]
        public IActionResult Accounts()
        {
            return View(BankAccounts);
        }
    }
}
