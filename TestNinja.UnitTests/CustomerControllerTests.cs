using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        private CustomerController _customerController;

        [SetUp]
        public void SetUp()
        {
            _customerController = new CustomerController();
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var result = _customerController.GetCustomer(0);

            // Not Found (exact object)
            Assert.That(result, Is.TypeOf<NotFound>());

            // Not Found (or one of its derivatives)
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var result = _customerController.GetCustomer(8);

            // Not Found (exact object)
            Assert.That(result, Is.TypeOf<Ok>());

            // Not Found (or one of its derivatives)
            Assert.That(result, Is.InstanceOf<Ok>());
        }
    }
}
