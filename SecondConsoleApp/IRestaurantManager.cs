using System;
using System.Collections.Generic;
using System.Text;

namespace SecondConsoleApp
{
    interface IRestaurantManager
    {
        List<MenuItem> MenuItems {get;}
        List<Order> Orders {get;}
        public void AddOrder();
        public void RemoveOrder();
        public List<Order> GetOrdersByDatesInterval(DateTime startdate, DateTime enddate);
        public List<Order> GetOrderByDate(DateTime dateTime);
        public List<Order> GetOrdersByPriceInterval(double price1, double price2);
        public Order GetOrderByNo(string no);
        public void AddMenuItem(string name, double price, string cotegory);




    }
}
