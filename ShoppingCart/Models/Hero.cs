using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCart.Models
{
    public partial class Hero
    {
        private string name;
        private string publisher;

        public Hero()
        {
            name = null;
            publisher = null;
        }

        public Hero(string _name, string _publisher)
        {
            name = _name;
            publisher = _publisher;
        }

        public string getName()
        {
            return name;
        }

        public string getPublisher()
        {
            return publisher;
        }
    }
}
