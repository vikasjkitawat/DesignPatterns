using FacadeBankLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeBankClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BankFacade facade = new BankFacade("123456789", "1234");
            facade.WithdrawAmount(300);

            facade.WithdrawAmount(4800);

            Console.ReadKey();

        }
    }
}
