using Bank.Entities;
using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of the Account: ");
            int numberAccount = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of the Agency: ");
            int numberAgency = int.Parse(Console.ReadLine());
            Console.Write("Enter the name of the client: ");
            string nameClient = Console.ReadLine();
            Console.Write("Enter the Balance Initial of Account: ");
            double balanceInitial = double.Parse(Console.ReadLine());

            Account acc1 = new Account(numberAccount, balanceInitial);
            Client client1 = new Client(nameClient, acc1);
            Agency agency = new Agency(numberAgency);

            agency.AddClient(client1);

            Console.WriteLine();
            
            agency.DBClient();



            Console.ReadKey();
        }
    }
}
