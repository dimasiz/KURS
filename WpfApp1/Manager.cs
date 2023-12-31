using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KursC_10_8
{
    internal class Manager: Сonsultant , IChanging
    {
        public Client CreateClient(string name,string secondName,string lastName,string number, string numberOfPasprot)
        {
  
            DateTime data = DateTime.Now;
            Client client = new Client(name, secondName, lastName, number, numberOfPasprot, data.ToString(), null, null);
            return client;
        }

        
        

        public Client Changed(Client client, string name, string secondName, string lastName, string number, string pasport)
        {
            client.DataChange = "";
            if(client.Name != name)
            {
                client.Name = name;
                client.DataChange += "\nИмя";
            }
           
            if (client.SecondName != secondName)
            {
                client.SecondName = secondName;
                client.DataChange += "\nФамилия";
            }
                 
            if(client.LastName != lastName)
            {
                client.LastName = lastName;
                client.DataChange += "\nОттчество";
            }       

            if(client.Number != number)
            {
                client.Number = number;
                client.DataChange += "\nНомер";
            }
            
            if(client.NumberOfPasport != pasport)
            {
                client.NumberOfPasport = pasport;
                client.DataChange += "\nПаспорт";
            }
      
            client.TimeChange = DateTime.Now.ToString();
            client.ChangedData = "Менаджер";
            return client;
            

        }
    }
}
