using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cargoinheritence
{  //natamam :(
    public class Category : catprod
    {

        public string Description;
        public Product[] prd;
    }

    public class Product : catprod
    {
        public decimal Price;
        public int Amount;
        public int UnitsInStock;
        public Category ctg;
    }

    public class Customer:basecustomer
    {
        public string FirstName;
        public string LastName;
       
    }
    public class CustomerMail : basecustomer
    {
        public string Email;

    }
    public class Address:basecustomer
    {

        public string City;
        public string Region;
        public string Town;
        public string Street;
        public string BuildingNo;
                                       

    }
    public class Phone:basecustomer
    {
        public int Number;
        public string AreaCode;
    }
    public class Order
    {
        public int Id;               
        public int CustomerId        ;
        public DateTime OrderDate    ;
        public DateTime DeliveredDate;
        public int ShipperId         ;
        public int CustomerAdderessId;
        public string Status         ;
        public OrderDetail od;
    }
    public class OrderDetail
    {
        public int Id;
        public Order[] ord;

    }
    public class Shipper :catprod
    {
        public int phone;
    }
}
