using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingModel
{
    public class Account
    {

        //private string name;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //private string _name;
        //public string  getName()
        //{
        //    return _name;
 
        //}
        //public void setName(string name)
        //{
        //    _name = name;
 
        //}
         //Manera alternativa
        //public string  Name
        //{
        //    get 
        //    {
        //       return _name;
        //    }
        //    set
        //    {
        //        _name = value; 
        //    }
        //}
        
        public string Name { get; set; }
        private decimal _balance;
        public Account()
        {
 
        }
        public Account(string name)
        {
            Name = name;
        }
        public Account(string name , decimal initialbalance)
        {
            Name = name;
            Balance = initialbalance;
        }
        public decimal Balance
        {
            get { return _balance; }
            set { if (value > 0.0m) { _balance = value; } }
        }
        public void Deposit(decimal depositAmount)
        {
            if(depositAmount>0.0m)
            {
                Balance += depositAmount;
            }
        }

    }

}
