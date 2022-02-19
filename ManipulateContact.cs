using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class ManipulateContact
    {
        List<ContactDetails> AddressBookList = new List<ContactDetails>();
        public void AddingContact
            (
            string Name,
            string Address,
            string City,
            string State,
            string ZipCode,
            string PhoneNumber,
            string Email
            ) 
        {
            AddressBookList.Add
                (new ContactDetails()
                {
                    Name = Name,
                    Address = Address,
                    City = City,
                    State = State,
                    ZipCode = ZipCode,
                    PhoneNumber = PhoneNumber,
                    Email = Email
                }
            );
            Console.WriteLine($"{Name} is added___________");
        }


        public void EditingContact(string Name)
        {
            foreach (var contact in AddressBookList)
            {
                if (contact.Name.Contains(Name))
                {
                    /*Console.WriteLine("plz provide new ");
                    contact.Address = Console.ReadLine();
                    Console.WriteLine("plz provide new ");
                    contact.City = Console.ReadLine();
                    Console.WriteLine("plz provide new ");
                    contact.State = Console.ReadLine();
                    Console.WriteLine("plz provide new ");
                    contact.ZipCode = Console.ReadLine();*/
                    Console.WriteLine("plz provide new phone number");
                    contact.PhoneNumber = Console.ReadLine();
                    Console.WriteLine("plz provide new email");
                   contact.Email = Console.ReadLine();
                    break;
                }
            }
        }

        public void DeletingContact(string Name)
        {
            foreach (var contact in AddressBookList)
            {
                if (contact.Name.Contains(Name))
                {
                    AddressBookList.Remove(contact);
                    Console.WriteLine($"{Name}'s Contact is deleted______");
                    break;
                }
            }
                }
    }
}
