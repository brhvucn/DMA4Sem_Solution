using DMA4Sem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA4Sem.DAL.Contracts
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomer(int id);
    }
}
