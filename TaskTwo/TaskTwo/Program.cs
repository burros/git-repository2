using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAddressBook;
using MyLogger;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook book = new AddressBook();
            // change class ConsoleLogger to FileLogger for write in the log file
            ILogger logger = ConsoleLogger.Instance;
            book.UserAdded += logger.Info;
            book.UserRemoved += logger.Info;
            book.UserNotAdded += logger.Warning;
            book.UserNotRemoved += logger.Warning;


            book.AddUser(new User("Joey", "Tribbiani", "jtr@mail.com", new DateTime(1980, 01, 10), "New York", "Bedford 90", "+44 20 7946 0213", Gender.Male));
            book.AddUser(new User("Chandler", "Bing", "chb@mail.com", new DateTime(1980, 01, 10), "New York", "Bedford 90", "+44 20 7946 0213", Gender.Male));
            book.AddUser(new User("Monica", "Geller", "moge@mail.com", new DateTime(1980, 01, 10), "New York", "Bedford 90", "+44 20 7946 0213", Gender.Famale));
            book.AddUser(new User("Rachel", "Green", "rgr@mail.com", new DateTime(1980, 01, 10), "New York", "Bedford 90", "+44 20 7946 0213", Gender.Famale));
            book.AddUser(new User("Phoebe", "Buffay", "phb@mail.com", new DateTime(1980, 01, 10), "New York", "Bedford 90", "+44 20 7946 0213", Gender.Famale));
            book.AddUser(new User("Ross", "Geller", "rg@mail.com", new DateTime(1980, 01, 10), "New York", "Bedford 90", "+44 20 7946 0213", Gender.Male));
            book.AddUser(new User("Ross", "Geller", "rg@mail.com", new DateTime(1980, 01, 10), "New York", "Bedford 90", "+44 20 7946 0213", Gender.Male));
            book.RemoveUser("Joey", "Tribbiani", "jtr@mail.com");
            book.RemoveUser("David", "Crane", "dcr@mail.com");

            //show data from log file 
            //FileLogger fileLogger = (FileLogger)logger;
            //fileLogger.ShowLogMessages();
            Console.ReadKey();

        }


    }
}
