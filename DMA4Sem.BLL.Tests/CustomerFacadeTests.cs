using DMA4Sem.DAL.Contracts;
using DMA4Sem.Domain.Models;

namespace DMA4Sem.BLL.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetCustomer_Invalid_Id_ExpectException()
        {
            //arrange
            ICustomerRepository testCustomerRepository = new FakeCustomerRepository();
            CustomerFacade customerFacade = new CustomerFacade(testCustomerRepository);
            //act
            Action act = () => customerFacade.GetCustomer(0);
            //assert
            var exception = Assert.ThrowsAny<Exception>(act);



            Customer customer = Customer.CreateCustomer(1, "Kurt", "");
            customer.Name = "Hans";


        }        
    }

   
}
