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
        public Task<Customer> GetCustomer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
