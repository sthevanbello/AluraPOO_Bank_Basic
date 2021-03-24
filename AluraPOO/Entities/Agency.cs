using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities
{
    class Agency
    {
        public int Number { get; set; }
        private List<Client> ListClientData { get; set; } = new List<Client>();

        public Agency()
        {

        }

        public Agency(int number)
        {
            Number = number;
        }

        public void NewClient()
        {
            Console.Write("Enter the number of the Account: ");
            int numberAccount = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of the Agency: ");
            int numberAgency = int.Parse(Console.ReadLine());
            Console.Write("Enter the name of the client: ");
            string nameClient = Console.ReadLine();
            Console.Write("Enter the Balance Initial of Account: ");
            double balanceInitial = double.Parse(Console.ReadLine());

            Account acc1 = new Account(numberAccount, balanceInitial, new Agency(numberAgency));
           
            AddClient(new Client(nameClient, acc1));

        }



        private void AddClient(Client client)
        {
            ListClientData.Add(client);
        }

        private void RemoveClient(Client client)
        {
            ListClientData.Remove(client);
        }

        public void DBClient()
        {
            foreach (var item in ListClientData)
            {
                Console.WriteLine(item);
            }
        }

    }
}
