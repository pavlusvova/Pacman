using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pacman.Models;

namespace Pacman.Pages
{
    public class GameModel : PageModel
    {
    

        public int Rows { get; set; }
        public int Columns { get; set; }
        public Map Map { get; set; }

       
        public void OnGet()
        {

        }

        public GameModel()
        {
            Map = new Map();
            Rows = Map.Elements.GetUpperBound(0) + 1;
            Columns = Map.Elements.Length / Rows;  
            
        }
    }
}








//public Map GetMap(int key, Map map)
//{
//        for (var y = 0; y < 30; y = y + 1)
//        {
//            for (var x = 0; x < map[y].length; x = x + 1)
//            {
//                if (map[y][x] == 1)
//                {
//                    Element.innerHTML += "<div class='wall'></div>";
//                }
//                else  if (map[y][x] == 2)
//                {
//                    Element.innerHTML += "<div class='coin'></div>";
//                }
//                else if (map[y][x] == 3)
//                {
//                    Element.innerHTML += "<div class='ground'></div>";
//                }
//                else if (map[y][x] == 4)
//                {
//                    Element.innerHTML += "<div class='ghost'></div>";
//                }
//                else if (map[y][x] == 5)
//                {
//                    Element.innerHTML += "<div class='pacman'></div>";
//                }
//            }
//            Element.innerHTML += "<br>";
//        }

//    return map;
//}



