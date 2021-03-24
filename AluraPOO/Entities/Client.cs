using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities
{
    class Client
    {
        public string Name { get; set; }
        private Account AccountData { get; set; }


        

        public Client(string name, Account account)
        {
            Name = name;
            AccountData = account;
            
        }


        public override string ToString()
        {
            return $"Name of the holder: {Name}\n\nData of the account\n{AccountData}";
        }



    }
}
