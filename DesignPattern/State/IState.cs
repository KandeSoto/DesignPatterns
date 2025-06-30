using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public interface IState
    {
        public void Action(CustomerContext customerContext, decimal amount);
    }
}
