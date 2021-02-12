using System;
using System.Collections.Generic;
using System.Text;

namespace SecondConsoleApp
{
    class Order
    {
        static private  int _No = 1;
        List<OrderItem> OrderItems;
        public int TotalAmount;
        DateTime Date;

        public Order()
        {
            _No++;
        }
    }
}
