using Bank.Entities;
using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            Agency agency = new Agency();

            agency.NewClient();

            agency.DBClient();

            double value = 500.00;

            foreach (var item in agency.ListClientData)
            {
                item.AccountData.Deposit(value);
            }
            agency.DBClient();

            Console.ReadKey();
        }
    }
}
