using System;
using System.Collections.Generic;
using System.Text;

namespace SecondConsoleApp
{
    class RestaurantManager : IRestaurantManager
    {
        public List<MenuItem> MenuItems {get  => this._menuitems;}
        public List<Order> Orders {get => this._orders;}
        private List<MenuItem> _menuitems;
        private List<Order> _orders;

        public RestaurantManager()
        {
            _menuitems = new List<MenuItem>();
            _orders = new List<Order>();
        }

        public void AddMenuItem(string name, double price, string cotegory)
        {
            _menuitems.Add(new MenuItem() { Name = name, Price = price, Category = cotegory });
        }

        public void AddOrder()
        {
            
        }

        public List<Order> GetOrderByDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public Order GetOrderByNo(string no)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrdersByDatesInterval(DateTime startdate, DateTime enddate)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrdersByPriceInterval(double price1, double price2)
        {
            throw new NotImplementedException();
        }

        public void RemoveOrder()
        {
            throw new NotImplementedException();
        }

        public List<MenuItem> GetMenuItems()  //svoya proverochnaya
        {
            return MenuItems;
        }
    }
}
