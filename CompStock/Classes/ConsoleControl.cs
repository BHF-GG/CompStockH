using System;
using System.Collections.Generic;
using System.Text;
using CompStock.Interfaces;

namespace CompStock.Classes
{
    class ConsoleControl : IBtnControl
    {
        public int GetBtnPushed()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();

            return int.Parse(userInput.KeyChar.ToString());
        }
    }
}
