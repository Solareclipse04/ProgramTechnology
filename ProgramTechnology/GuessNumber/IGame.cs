using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Интерфейс IGame, реализовван в классе GuessNumberGame
namespace GuessNumber
{
    internal interface IGame
    {
        void Run();
        void Output(string output);
    }
}
