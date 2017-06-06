using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeBankLibrary
{
    public class BankFacade
    {
        private string accountNumber;
        private string pin;

        public BankFacade(string accountNumber, string pin)
        {
            this.accountNumber = accountNumber;
            this.pin = pin;
        }

        public void WithdrawAmount(double Amount)
        {
            throw new NotImplementedException();
        }

        public void DepositAmount(double Amount)
        {
            throw new NotImplementedException();
        }
    }
}
