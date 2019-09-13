using System;
using CompStock.Classes;

namespace CompStock
{
    class Application
    {
        static void Main(string[] args)
        {
            
            CompStockClass compStock = new CompStockClass(new ConsoleControl());

            compStock.Run();
        }
    }
}
