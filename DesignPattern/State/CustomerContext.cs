﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.State
{
    public class CustomerContext
    {
        private IState _state;

        private decimal _residue;

        public decimal Residue
        {
            get { return _residue; } 
            set { _residue = value; }
        }

        public CustomerContext() 
        {
            _state = new NewState();
        }

        public void SetState(IState state) => _state = state;
        public IState GetState() => _state;

        public void Request(decimal amount) => _state.Action(this, amount);

        public void Discount(decimal amount) => _residue -= amount;
    }
}
