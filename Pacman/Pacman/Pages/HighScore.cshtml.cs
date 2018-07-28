using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pacman.Models;

namespace Pacman.Pages
{
    public class HighScoreModel : PageModel
    {
        private readonly IUserRepository _userRepository;
        public List<User> Users { get; set; }

        public HighScoreModel(IUserRepository _userRepository)
        {
            this._userRepository = _userRepository;
            Users = _userRepository.GetAllUsers().OrderByDescending(u => u.Score).Take(10).ToList();
        }

        public void OnGet()
        {
         
        }
        

    }
}