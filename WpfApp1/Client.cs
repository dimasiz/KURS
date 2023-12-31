using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace KursC_10_8
{
    internal class Client
    {
        private string _name;
        private string _secondName;
        private string _lastName;
        private string _number;
        private string _numberOfPasprot;
        private string _timeChange;
        private string _dataChange;
        private string _changedData;
        public Client(string _name, string _secondName, string _lastName, string _number, string _numberOfPasprot, string _timeChange, string _dataChange, string _changedData)
        {
            this.Name = _name;
            this.SecondName = _secondName;
            this.LastName = _lastName;
            this.Number = _number;
            this.NumberOfPasport = _numberOfPasprot;
            this.TimeChange = _timeChange;
            this.DataChange = _dataChange;
            this.ChangedData = _changedData;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string SecondName
        {
            get { return _secondName; }
            set { _secondName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public string NumberOfPasport
        {
            get { if (_numberOfPasprot != null)
                {
                    return "***************";
                }
                else
                {
                    return null;
                }; }

            set { _numberOfPasprot = value; }
        }

        public string TimeChange { get; set; }

        public string DataChange { get; set; }
        public string ChangedData {  get; set; }

    


    }
}
