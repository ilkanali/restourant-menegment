﻿using System;
using System.Collections.Generic;
using System.Text;

namespace restaurant_menegment_project
{
   public class MenuItem
    {
        public string No { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public MenuItem(string no, string name, double price, Category category)
        {

            this.No = no;
            this.Name = name;
            this.Price = price;
            this.Category = category;
        }
}
