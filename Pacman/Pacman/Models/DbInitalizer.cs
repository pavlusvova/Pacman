using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacman.Models
{
    public class DbInitalizer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Users.Any())
            {
                context.AddRange
                    (
                     new User { Name = "Bob", Score = 100 },
                     new User { Name = "Jack", Score = 300 },
                     new User { Name = "Vova", Score = 400 },
                     new User { Name = "Roma", Score = 200 },
                     new User { Name = "Dima", Score = 500 },
                     new User { Name = "Jim", Score = 600 },
                     new User { Name = "Tod", Score = 700 },
                     new User { Name = "Lisa", Score = 800 },
                     new User { Name = "Kate", Score = 900 },
                     new User { Name = "Gomer", Score = 250 },
                     new User { Name = "Bart", Score = 260 },
                     new User { Name = "Timi", Score = 210 }
                    );
                context.SaveChanges();
            }
        }
    }
}
