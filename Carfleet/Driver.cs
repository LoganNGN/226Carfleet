using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Carfleet
{
    public class Driver:Person
    {
        private string _workZone;
        
        public Driver(string name, string firstname, string phonenumber, string emailaddress, string workZone, List<string> languages):base(name,firstname, phonenumber, emailaddress, languages)
        {
            _workZone = workZone;
        }
        public string WorkZone
        {
            get
            {
                return _workZone;
            }
            set
            {
                _workZone = value;
            }
        }
    }
}
