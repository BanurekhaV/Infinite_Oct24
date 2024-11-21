using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI_With_Unity.Abstractions;

namespace DI_With_Unity
{
    class BusinessLayer
    {
        IProducts products;
        IOrders orders;

        //DI in the constructor
        public BusinessLayer(IProducts ip, IOrders io)
        {
            products = ip;
            orders = io;
        }

        public string Insert()
        {
            return products.InsertProducts();  //this call is actually to invoke the implementor (concreteproduct) 
        }

        public void Display()
        {
            orders.DisplayOrders();  //call to concreteorder
        }
    }
}
