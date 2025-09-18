using DMA4Sem.BLL.Contracts;
using DMA4Sem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA4Sem.BLL
{
    public class CustomerFacade : ICustomerFacade
    {
        public Task<Customer> GetCustomer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
