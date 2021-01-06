using System;
using System.Collections.Generic;
using System.Text;

namespace restaurant_menegment_project
{
    public class OrderItem
    {

        public string MenuItem { get; set; }
        public double count { get; set; }

        public OrderItem(string menuitem,double count);
        {  
           this.Count = count;
           this.MenuItem = MenuItem;      

    }
}
