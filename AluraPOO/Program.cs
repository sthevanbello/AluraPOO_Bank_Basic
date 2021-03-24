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


            Console.ReadKey();
        }
    }
}
