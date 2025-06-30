using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class BicycleStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy una bicicleta y me muevo a 2 llantas");
        }
    }
}
