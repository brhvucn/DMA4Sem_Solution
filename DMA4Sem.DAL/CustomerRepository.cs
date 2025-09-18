using DMA4Sem.DAL.Contracts;
using DMA4Sem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA4Sem.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        public async Task<Customer> GetCustomer(int id)
        {
            Console.WriteLine($"Nu gemmer jeg i databasen: id {id}");
            Customer result = new Customer();
            return await Task.FromResult(result);
        }
    }
}
