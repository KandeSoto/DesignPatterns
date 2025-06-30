using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DependencyInjection
{
    public class DrinkWithBeer
    {
        private Beer _beer;
        public decimal _water { get; set; }
        public decimal _sugar { get; set; }

        public DrinkWithBeer(decimal water, decimal sugar, Beer beer)
        {
            _water = water;
            _sugar = sugar;
            _beer = beer;
        }

        public void build()
        {
            Console.WriteLine($"Preparamos bebida que tiene agua {_water} azucar {_sugar} y cerveza {_beer.Name}");

        }
    }
}
