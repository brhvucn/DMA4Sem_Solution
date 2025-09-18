using DMA4Sem.BLL.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DMA4Sem_Meta.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerFacade customerFacade;
        public CustomerController(ICustomerFacade customerFacade)
        {
            this.customerFacade = customerFacade;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var customer = await this.customerFacade.GetCustomer(id);
            return new ObjectResult(customer);
        }
    }
}
