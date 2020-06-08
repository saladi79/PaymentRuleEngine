using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine
{
    public class ProductFactory
    {
        public BaseProduct CreateProduct(Product product, Customer customer)
        {
            BaseProduct returnValue = null;
            if (product.ProductType == ProductType.Physical)
            {
                returnValue = new PhysicalProduct(product, customer);
            }
            else if (product.ProductType == ProductType.Membership)
            {
                returnValue = new MembershipProduct(product, customer);
            }
            else if (product.ProductType == ProductType.Digital)
            {
                returnValue = new DigitalProduct(product, customer);
            }
            return returnValue;
        }
    }
} 


