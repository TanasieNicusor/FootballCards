using FootballCards.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FootballCards.Controllers
{
    public class MultiplayerLobbyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
