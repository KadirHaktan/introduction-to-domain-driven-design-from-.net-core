using OrderSample.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSample.Domain.AggregateModels.OrderModels
{
    public class Order:BaseEntity,IAggregateRoot
    {
        public DateTime OrderDate { get; private set; }

        public string Description { get; private set; }

        public int BuyerId { get; private set; }

        public string OrderStatus { get; private set; }

        public Address Address { get; private set; }


        public Order(DateTime orderDate,string description,int buyerId,string orderStatus,Address address)
        {
            this.OrderDate = orderDate;
            this.Description = description;
            this.BuyerId = buyerId;
            this.OrderStatus = orderStatus;
            this.Address = address;
        }

    }
}
