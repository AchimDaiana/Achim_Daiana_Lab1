using Microsoft.AspNetCore.Mvc;
using System.Windows;

namespace Achim_Daiana_Lab1.Controllers
{
    public class FirstController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
           
        }*/

        
        public string Index()
        {
            string message = "Bine ai venit pe acesta platforma!";
            return message;
        }

        
        public string Welcome()
        {
            string salute = "Salut!";
            return salute;
        }

       
        public string WelcomeUser(string name, int id)
        {
            name = "Daiana";
            id = 1;
            return "Salut " + name + ",id-ul tau este: " + id;
        }
    }
}
