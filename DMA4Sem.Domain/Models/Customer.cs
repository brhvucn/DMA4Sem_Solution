using EnsureThat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA4Sem.Domain.Models
{
    public class Customer
    {
        private Customer(int id, string name, string email)
        {
            Ensure.That(id, nameof(id)).IsGt(0);
            Ensure.That(name, nameof(name)).IsNotNullOrEmpty();
            Ensure.That(email, nameof(email)).IsNotNullOrEmpty();

            this.Name = name;
            this.Id = id;
            this.Email = email;
        }

        public static Customer CreateCustomer(int id, string name, string email)
        {
            return new Customer(id, name, email);
        }       

        public int Id { get; }
        public string Name { get; }
        public string Address { get; set; } = string.Empty;
        public string Email { get; }
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
