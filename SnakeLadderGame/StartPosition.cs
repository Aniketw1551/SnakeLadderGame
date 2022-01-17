using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class StartPosition
    {
        // Intance variable
        int position = 0;

        public void StartGame() //Calling Method
        {
            Console.WriteLine("Player position is: " + position);
        }
    }
}
