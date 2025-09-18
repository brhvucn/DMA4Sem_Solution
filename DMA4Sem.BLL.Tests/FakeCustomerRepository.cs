using DMA4Sem.DAL.Contracts;
using DMA4Sem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA4Sem.BLL.Tests
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public Task<Customer> GetCustomer(int id)
        {
            Console.WriteLine($"Fake nu henter jeg i databasen: id {id}");
            Customer result = new Customer();
            return Task.FromResult(result);
        }
    }
}
