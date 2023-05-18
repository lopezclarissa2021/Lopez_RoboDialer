using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lopez_RoboDialer.Models
{
    internal class HomePhone : Phone
    {
        public HomePhone(string companyName, string phoneNumber, int phoneType) : base(companyName, phoneNumber, phoneType)
        {
        }

        public override string Dial()
        {
            return $"{CompanyName} is being dialed using {PhoneNumber}..."; ;
        }
    }
}
