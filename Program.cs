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
            DeleteContact();
        }

        public static void AddContact()
        {
            Console.WriteLine("how many contacts do you want to add?");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("enter name");
                string Name = Console.ReadLine();
                Console.WriteLine("enter address");
                string Address = Console.ReadLine();
                Console.WriteLine("enter city");
                string City = Console.ReadLine();
                Console.WriteLine("enter state");
                string State = Console.ReadLine();
                Console.WriteLine("enter zip code");
                string ZipCode = Console.ReadLine();
                Console.WriteLine("enter phone number");
                string PhoneNumber = Console.ReadLine();
                Console.WriteLine("enter email id");
                string Email = Console.ReadLine();
                ContactDetails detail = new ContactDetails();
                manipulate.AddingContact(
                    detail.Name = Name,
                    detail.Address = Address,
                    detail.City = City,
                    detail.State = State,
                    detail.ZipCode = ZipCode,
                    detail.PhoneNumber = PhoneNumber,
                    detail.Email = Email
                    );
            }
        }

        public static void EditContact()
        {
            Console.WriteLine("enter name you want edit");
            string Name = Console.ReadLine();
            manipulate.EditingContact(Name);
        }
        public static void DeleteContact()
        {
            Console.WriteLine("enter name you want delete");
            string Name = Console.ReadLine();
            manipulate.DeletingContact(Name);
        }
    }
}
