using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DependencyInjection
{
    public class Beer
    {
        public string _name { get; set; }
        public string _brand { get; set; }

        public string Name
        {
            get { return _name; }
        }

        public Beer(string name, string brand) 
        {
            _name = name;
            _brand = brand;
        }
    }
}
