using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseProgram.Models
{
    class UserClass
    {
        private string name;
        private float balance;

        public UserClass(string name, float balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void UpdateBalance(float price)
        {
            this.balance = this.balance - price;
        }

        public string GetName()
        {
            return this.name;
        }

        public float GetBalance()
        {
            return this.balance;
        }

    }
}
