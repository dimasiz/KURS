using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursC_10_8
{
    interface IChanging
    {
        public Client Changed(Client client, string name, string secondName, string lastNane, string number, string pasport);
    }
}
