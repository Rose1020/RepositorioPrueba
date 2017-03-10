using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingModel
{
    public class Account
    {

        private string _name;

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
        public string  Name
        {
            get 
            {
               return _name;
            }
            set
            {
                _name = value; 
            }
        }

        //public string Name { get; set; }

    }

}
