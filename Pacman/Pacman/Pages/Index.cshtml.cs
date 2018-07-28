using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pacman.Models;

namespace Pacman.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IUserRepository userRepository;

        public IndexModel(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void OnGet()
        {
           
        }
    }
}
