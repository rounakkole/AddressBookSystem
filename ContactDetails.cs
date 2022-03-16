﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class ContactDetails
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }




        public override string ToString()
        {
            return $"{this.Name}  {this.Address}  {this.City}  {this.State}  {this.ZipCode}  {this.PhoneNumber}  {this.Email}";
        }

    }
}
