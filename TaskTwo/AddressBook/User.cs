using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAddressBook
{
    public enum Gender
    {
        Male, Famale
    }
    public class User
    {
        private readonly DateTime _timeAdded;
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime TimeAdded
        {
            get { return _timeAdded; }
        }
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }

        // first name, second name, email for personal identification user
        // i use it when i will be invoke method AddUser and RemoveUser
        public User(string firstName, string secondName, string email)
        {
            FirstName = firstName;
            SecondName = secondName;
            Email = email;
            _timeAdded = DateTime.Now;
        }
        public User(string firstName, string secondName, string email, DateTime birthdate, string city, string address, string phoneNumber, Gender gender)
        {
            FirstName = firstName;
            SecondName = secondName;
            Email = email;
            Birthdate = birthdate;
            City = city;
            Address = address;
            PhoneNumber = phoneNumber;
            _timeAdded = DateTime.Now;
        }
    }

}
