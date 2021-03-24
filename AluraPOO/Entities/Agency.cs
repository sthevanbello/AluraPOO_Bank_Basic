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

        public Agency(int number)
        {
            Number = number;
        }

        public void AddClient(Client client)
        {
            ListClientData.Add(client);
        }

        public void RemoveClient(Client client)
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
