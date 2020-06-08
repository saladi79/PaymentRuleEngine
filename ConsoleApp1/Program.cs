using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentRuleEngine;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product _product=new Product();
            Customer _customer=new Customer();

           BaseProduct productFactory = new ProductFactory().CreateProduct(_product, _customer);
            productFactory.PurchaseProduct();

        }

        
    }
}

