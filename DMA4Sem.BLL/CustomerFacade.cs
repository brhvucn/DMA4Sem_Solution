using DMA4Sem.BLL.Contracts;
using DMA4Sem.DAL.Contracts;
using DMA4Sem.Domain.Models;
using EnsureThat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMA4Sem.BLL
{
    public class CustomerFacade : ICustomerFacade
    {
        private readonly ICustomerRepository customerRepository;
        public CustomerFacade(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public Task<Customer> GetCustomer(int id)
        {
            Ensure.That(id, nameof(id)).IsGt(0);

            //forretningslogik er her
            //hvis jeg når hertil er id ok
            return this.customerRepository.GetCustomer(id);
        }

        public Task<Customer> GetCustomerNull(int id)
        {
            if(id <= 0)
            {
                return null;
            }
            //forretningslogik er her
            //hvis jeg når hertil er id ok
            return this.customerRepository.GetCustomer(id);
        }
    }
}
