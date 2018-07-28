using Microsoft.AspNetCore.Mvc;
using Pacman.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacman.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepository;

        public HomeController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {

            var users = _userRepository.GetAllUsers().OrderBy(p => p.Name);

            var homeViewModel = new HomeViewModel
            {
                Users = users.ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
                return NotFound();

            return View(user);
        }
    }
}
