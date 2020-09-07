using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Image;

        public readonly User _creator;
        private readonly DateTime _createdDate;
        
        
        public User _owner;
        public DateTime UpdatedDate { get; set; }

        public User(string firstName, string lastName, string image, User _creator)
        {
            FirstName = firstName;
            LastName = lastName;
            Image = image;
            Id = Guid.NewGuid().ToString();
            _createdDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }

    }
}
