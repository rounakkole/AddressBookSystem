using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CsvHelper;

namespace AddressBookSystem.Servieces
{
    internal class CsvIO
    {
        public const string CsvPath = @"C:\Users\rounak\source\repos\AddressBookSystem\Utility\Contacts.csv";

        public void CsvWrite(List<ContactDetails> AddressBookList)
        {
        File.WriteAllText(CsvPath, string.Empty);
            var stream = File.Open(CsvPath, FileMode.Append);
            using (StreamWriter sw = new StreamWriter(stream))
            using (CsvWriter csvWriter = new CsvWriter(sw, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(AddressBookList);
            }
            CsvRead();
        }

        public static void CsvRead()
        {
            using (StreamReader sr = new StreamReader(CsvPath))
            using (CsvReader csvReader = new CsvReader(sr, CultureInfo.InvariantCulture))
            {
                var AddressBookList = csvReader.GetRecords<ContactDetails>().ToList();
                foreach (ContactDetails Contact in AddressBookList)
                {
                    Console.WriteLine(Contact.ToString());
                }
            }
        }



    }
}
