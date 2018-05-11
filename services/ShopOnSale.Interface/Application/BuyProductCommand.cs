using System;
using System.Collections.Generic;
using System.Text;

namespace ShopOnSale.Interface.Application
{
    public class BuyProductCommand
    {
        public BuyProductCommand(string id)
        {
            Id = id;
        }

        public string Id { get; }
    }
}
