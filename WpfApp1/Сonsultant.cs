using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Navigation;

namespace KursC_10_8
{
    internal class Сonsultant: IChangedNumber
    {
        public List<Client> CreateList()
        {
            return new List<Client>();
        }

        public List<Client> WatchList(List<Client> clients)
        {
            return clients;
        }


        public Client WatchInfo(Client client)
        {
           
            Client Newclient = new Client(client.Name, client.SecondName, client.LastName, client.Number, client.NumberOfPasport, client.TimeChange, client.DataChange , client.ChangedData);
            return Newclient;
        }
        public Client ChangedNumber(Client client, string number)
        {
                client.TimeChange = DateTime.Now.ToString();
                client.DataChange = "Номер телефона";
                client.ChangedData = "Консультант";
                client.Number = number;
            
            return client;
        }


    }
}
