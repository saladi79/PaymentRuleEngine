using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentRuleEngine
{
    public enum ProductType
    { Physical, Membership, Digital}

    public enum ProductSubType
    { Book, Video, NewMembership, UpdateMembership }


    public abstract class BaseProduct
    {        
        protected Product _product;
        protected Customer _customer;

        public BaseProduct(Product product, Customer customer)
        {
            _product = product;
            _customer = customer;
        }

        public abstract bool PurchaseProduct();

    }

    public class PhysicalProduct : BaseProduct
    {
        ShipmentManager _shipmentManager = new ShipmentManager();        

        public PhysicalProduct(Product product, Customer customer) : base(product, customer)
        {
        }
        
        public override bool PurchaseProduct()
        {
            _shipmentManager.GeneratePackingSlip(false); //generaton of packing slip for generation   


            if(_product.ProductSubType==ProductSubType.Book)
            {
                _shipmentManager.GeneratePackingSlip(true); //generaton of duplicate packing slip for royality department   
            }            
            return true;
        }
    }

    public class MembershipProduct : BaseProduct
    {
        ShipmentManager _shipmentManager = new ShipmentManager();
        MailManager _mailManager = new MailManager();

        public MembershipProduct(Product product, Customer customer) : base(product, customer)
        {
        }

        public override bool PurchaseProduct()
        {
            _shipmentManager.GeneratePackingSlip(false); //generaton of packing slip for generation   
            Product _product = new Product();

            if (_product.ProductSubType == ProductSubType.NewMembership)
            {
                //add membership                
            }

            if (_product.ProductSubType == ProductSubType.UpdateMembership)
            {
                //update membership                
            }

            //send mail
            _mailManager.SendEmail();

            return true;
        }
    }

    public class DigitalProduct : BaseProduct
    {
        ShipmentManager _shipmentManager = new ShipmentManager();        

        public DigitalProduct(Product product, Customer customer) : base(product, customer)
        {
        }

        public override bool PurchaseProduct()
        {            
            if (_product.ProductSubType == ProductSubType.Video)
            {
                _shipmentManager.GeneratePackingSlip(false); //generaton of duplicate packing slip for royality department   
            }            
            return true;
        }
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
