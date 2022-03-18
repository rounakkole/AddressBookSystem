using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem.Servieces
{
    internal class JsonIO
    {
        public const string JsonPath = @"C:\Users\rounak\source\repos\AddressBookSystem\Utility\Contacts.json";


        public void JsonWrite(List<ContactDetails> AddressBookList)
        {
            File.WriteAllText(JsonPath, string.Empty);
            foreach (var book in AddressBookList)
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                var stream = File.Open(JsonPath, FileMode.Append);
                using (var streamwriter = new StreamWriter(stream))
                using (var jsonwriter = new JsonTextWriter(streamwriter))
                {
                    foreach (ContactDetails contact in AddressBookList)
                    {
                        jsonSerializer.Serialize(jsonwriter, contact);
                    }
                }
            }
            JsonRead();
        }

        public static void JsonRead()
        {
            /* using (Stream Stream = new FileStream(JsonPath, FileMode.Open))
             using (StreamReader SR = new StreamReader(Stream))
             using (JsonReader Reader = new JsonTextReader(SR))
             {
                 JsonSerializer Serializer = new JsonSerializer();
                 List<ContactDetails> AddressBookList = Serializer.Deserialize<List<ContactDetails>>(Reader);

                 foreach (ContactDetails contacts in AddressBookList)
                 {
                     Console.WriteLine(contacts.ToString());
                 }
             }*/

            ContactDetails contact = JsonConvert.DeserializeObject<ContactDetails>(File.ReadAllText(JsonPath));
            Console.WriteLine(contact.ToString());
        }
    }
}
