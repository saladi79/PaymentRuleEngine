using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusiessRuleEngine
{
    public abstract class BaseProduct
    {
        //private Product productName;
        //protected Product ProductName { get => productName; set => productName = value; }
        protected Product _product = new Product();
        Customer _customer;

        public abstract bool PurchaseProduct();

    }

    //public class Book : BaseProduct
    //{       

    //    ShipmentManager shipmentManager = new ShipmentManager();

    //    public override bool PurchaseProduct()
    //    {             
    //        shipmentManager.GeneratePackingSlip(false); //generaton of packing slip for generation
    //        shipmentManager.GeneratePackingSlip(true); //generaton of duplicate packing slip for royalty
    //        return true;
    //    }
        
    //}

    public class PhysicalProduct : BaseProduct
    {        
        ShipmentManager _shipmentManager = new ShipmentManager();
        Product _product = new Product();

        public override bool PurchaseProduct()
        {
            shipmentManager.GeneratePackingSlip(false); //generaton of packing slip for generation   
            
            //if(_product.)
            return true;
        }
    }

    public class MembershipProduct : BaseProduct
    {
        public override bool PurchaseProduct()
        {
            throw new NotImplementedException();
        }
    }

    //public class Video : BaseProduct
    //{
    //    public override bool PurchaseProduct()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public class Product
    {
        int ProductId { get; set; }
        string ProductName { get; set; }        
        string ProductType { get; set; }
        
    }

    public class Customer
    {
        int CustomerId { get; set; }
        string CustomerName { get; set; }
        string PhoneNumber { get; set; }        
        string ShippingAddress { get; set; }    

    }

    public class ShipmentManager
    {
        private Product _product;
        private Customer _customer;        

        public ShipmentManager()
        {
            //_product = product;
            //_customer = customer;
        }
        public void GeneratePackingSlip(bool isDuplicateSlip)
        {
            //Generte packing slip related code
        }
    }

    public class MembershipManager
    {
        private Product _product;
        private Customer _customer;
        private MailManager _mail = new MailManager();

        public MembershipManager()
        {
            //_product = product;
            //_customer = customer;
        }
        public void ActivateMember(bool isNewMembership)
        {
            //Generte packing slip related code

            _mail.SendEmail();// mail to send after successful membership activation
        }


    }

    public class MailManager
    {       

        public MailManager()
        {
            //_product = product;
            //_customer = customer;
        }
        public void SendEmail()
        {
            //mail related code
        }


    }
}
