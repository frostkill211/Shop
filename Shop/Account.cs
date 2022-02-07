using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Account
    {
        public string AccountName { get; set; }
        public double Balance { get; set; }
        public string Adress { get; set; }
        public Account(string name, string adress, int balance)
        {
            AccountName = name;
            Adress = adress;
            Balance = balance;

        }
        public void ReduceBalance(double price)
        {
            Balance -= price;
        }
    }
}
