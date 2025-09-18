using DMA4Sem.DAL.Contracts;

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
        }

        [Fact]
        public void TestGetCustomer_Invalid_Id_ExpectNull()
        {
            //arrange
            ICustomerRepository testCustomerRepository = new FakeCustomerRepository();
            CustomerFacade customerFacade = new CustomerFacade(testCustomerRepository);
            //act
            var result = customerFacade.GetCustomerNull(0);
            //assert
            Assert.Null(result);
        }
    }

   
}
