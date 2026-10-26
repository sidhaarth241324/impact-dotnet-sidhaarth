using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public struct ContactCard
    {
        public string Name;
        public string PhoneNumber;
        public string Email;

        public ContactCard(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
