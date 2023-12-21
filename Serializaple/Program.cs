using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serializaple
{
    internal class Serializer
    {
        static void Main(string[] args)
        {
            var contact = new Contact("Igor", 89212636442, "@yandex.ru");

            BinaryFormatter bf = new BinaryFormatter();
            using (var formar = new FileStream("Contact.bin", FileMode.OpenOrCreate))
            {
                bf.Serialize(formar, contact);
            }
        }
    }

    [Serializable]
    class Contact
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public  Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

    
}