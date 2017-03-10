using BankingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTest
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Account myAccount = new Account();
            //Console.WriteLine("Ingrese el nombre: ");
            //string thename = Console.ReadLine();
            //myAccount.Name = thename;
            //Console.Write("Nombre inicial de la cuenta {0}", myAccount.Name);
            //Account myAccount = new Account("Juan Perez");
            //Console.Write("Nombre inicial de la cuenta {0}", myAccount.Name);
            Account myAccount1 = new Account("Juan Perez", 50.0m);
            Account myAccount2 = new Account("Brenda Garcia", -80.0m);
            Console.WriteLine("El saldo inicial de myAccount1({0}) es {1}", myAccount1.Name, myAccount1.Balance);
            Console.WriteLine("El saldo inicial de myAccount2({0}) es {1}", myAccount2.Name,myAccount2.Balance);
        }
    }
}
