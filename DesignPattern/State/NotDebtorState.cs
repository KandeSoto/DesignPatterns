using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public class NotDebtorState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            if (amount <= customerContext.Residue)
            {
                customerContext.Discount(amount);
                Console.WriteLine($"Solicitud permitida, gasta {amount} y le quesa de saldo {customerContext.Residue}");
                if (customerContext.Residue <= 0)
                    customerContext.SetState(new DebtorState());
            }
            else
            {
                Console.WriteLine($"No ajusta lo solicitado, " +
                    $"ya que tienes {customerContext.Residue} " +
                    $"y quieres gastar {amount}");
            }
        }
    }
}
