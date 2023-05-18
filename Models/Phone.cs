using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Clarissa Lopez
/// IT112
/// </summary>
namespace Lopez_RoboDialer.Models
{
    internal class Phone
    {
        protected string PhoneNumber;
        protected string CompanyName;
        protected int PhoneType;
        protected Phone(string companyName, string phoneNumber, int phoneType)
        {
            PhoneNumber = phoneNumber;
            CompanyName = companyName;
            PhoneType = phoneType;
        }

        public virtual string Dial()
        {
            string formattedDial = "";
            if (PhoneType == 2)
                formattedDial = $"{CompanyName} is being dialed using 1+{PhoneNumber}...";
            else if (PhoneType == 1)
                formattedDial = $"{CompanyName} is being dialed using {PhoneNumber}...";
            return formattedDial;
        }
    }
}
