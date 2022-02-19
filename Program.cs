// See https://aka.ms/new-console-template for more information
using System;

namespace AddressBookSystem
{
    internal class Program
    {
        public static ManipulateContact manipulate = new ManipulateContact();

        static void Main(string[] args)
        {
            Console.WriteLine("welcome to address book system");

            AddContact();
            EditContact();
        }

        public static void AddContact()
        {
            Console.WriteLine("how many contacts do you want to add?");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                ContactDetails detail = new ContactDetails();
                //ManipulateContact AddNewContact = new ManipulateContact();
                manipulate.AddingContact(
                    detail.Name = Console.ReadLine(),
                    detail.Address = Console.ReadLine(),
                    detail.City = Console.ReadLine(),
                    detail.State = Console.ReadLine(),
                    detail.ZipCode = Console.ReadLine(),
                    detail.PhoneNumber = Console.ReadLine(),
                    detail.Email = Console.ReadLine()
                    );

            }
        }

        public static void EditContact()
        {
            //ContactDetails detail = new ContactDetails();
            //ManipulateContact EditNewContact = new ManipulateContact();
            Console.WriteLine("enter name you want edit");
            string Name = Console.ReadLine();
            manipulate.EditingContact(Name);
        }
    }
}
