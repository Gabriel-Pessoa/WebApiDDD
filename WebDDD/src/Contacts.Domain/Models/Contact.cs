using System;

namespace Contacts.Domain.Models
{
    public class Contact : BaseEntity
    {
        public Contact(string name, string email) 
        {
            ValidateCategory(name, email);
            Name = name;
            Email = email;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }

        public void Update(string name, string email) 
        {
            ValidateCategory(name, email);
        }

        private void ValidateCategory(string name, string email)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new InvalidOperationException("The name is invalid");
            }

            if(string.IsNullOrEmpty(email)) 
            {
                throw new InvalidOperationException("The email is invalid");
            }
        }
    }
}