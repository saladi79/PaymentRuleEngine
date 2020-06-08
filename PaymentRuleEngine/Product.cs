using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public ProductType ProductType { get; set; }
        public ProductSubType ProductSubType { get; set; }

    }
}
