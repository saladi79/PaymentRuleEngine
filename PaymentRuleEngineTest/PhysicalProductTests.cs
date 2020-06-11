using NUnit.Framework;
using PaymentRuleEngine;

namespace Tests
{
    public class PhysicalProductTests
    {
        private Product _product;
        private Customer _customer;
        private PhysicalProduct _physicalProduct;

        private MembershipProduct _membershipProduct;

        [SetUp]
        public void Setup()
        {
            _product = new Product();
            _product.ProductId = 1;
            _product.ProductName = "ComputeScience";
            _product.ProductType = ProductType.Physical;
            _product.ProductSubType = ProductSubType.Book;

            _customer = new Customer();
            _customer.CustomerId = 1;
            _customer.CustomerName = "Surya";
            _customer.ShippingAddress = "Bangalore";

            _physicalProduct = new PhysicalProduct(_product, _customer);
            _membershipProduct = new MembershipProduct(_product, _customer);
        }

        [Test]
        public void PurchasePhysicalProductTest()
        {
            Assert.Equals(true, _physicalProduct.PurchaseProduct());
        }

        [Test]
        public void PurchaseMembershipProductTest()
        {
            Assert.Equals(true, _membershipProduct.PurchaseProduct());
        }
    }
}