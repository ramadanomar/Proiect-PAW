using Proiect_PAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Proiect_PAW.Data
{
    public class ClientCollection
    {
        private static ClientCollection _instance;
        private static readonly object _lock = new object();
        private List<Client> Clients { get; set; }

        private ClientCollection()
        {
            Clients = new List<Client>();
        }

        public static ClientCollection Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ClientCollection();
                    }
                    return _instance;
                }
            }
        }

        public void AddClient(Client client)
        {
            Clients.Add(client);
        }

        public bool RemoveClient(int clientId)
        {
            var client = Clients.FirstOrDefault(c => c.ClientId == clientId);
            if (client != null)
            {
                return Clients.Remove(client);
            }
            return false;
        }

        public List<Client> GetAllClients()
        {
            return new List<Client>(Clients);
        }

        public DataTable GetClientsDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ClientId", typeof(int));
            table.Columns.Add("Nume", typeof(string));
            table.Columns.Add("Sex", typeof(string)); 
            table.Columns.Add("Telefon", typeof(string));

            foreach (var client in Clients)
            {
                table.Rows.Add(client.ClientId, client.Nume, client.Sex.ToString(), client.Telefon);
            }

            return table;
        }
    }
}
