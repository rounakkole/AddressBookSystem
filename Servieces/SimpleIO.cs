using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem.Servieces
{
    internal class SimpleIO
    {

        public const string TxtPath = @"C:\Users\rounak\source\repos\AddressBookSystem\Utility\Simple.txt";
        public void SimpleWrite(List<ContactDetails> AddressBookList)
        {
            File.WriteAllText(TxtPath, string.Empty);
            foreach (ContactDetails contact in AddressBookList)
            {
                File.AppendAllText(TxtPath, contact.ToString() + Environment.NewLine);
            }
            Console.WriteLine("file write_________");
            SimpleRead();
        }

        public static void SimpleRead()
        {
            string lines = File.ReadAllText(TxtPath);
            Console.WriteLine(lines);
        }
    }
}
