using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.DisplayRules();
            game.SelectPlayers();
            game.CompareHumanGestures();
            
        }
    }
}
