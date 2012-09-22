using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace ShoppingCart.Models
{
    public partial class Heroes
    {
        public List<Hero> getHeroes()
        {
            List<Hero> list = new List<Hero>();
            XmlTextReader reader = new XmlTextReader(HttpContext.Current.Server.MapPath("/Content/heroes.xml"));

            while (reader.Read())
            {
                if(reader.Name == "hero")
                {
                    string name = reader.GetAttribute(0);
                    string publisher = reader.GetAttribute(1);

                    Hero hero = new Hero(name, publisher);
                    list.Add(hero);
                }
                //System.Diagnostics.Debug.WriteLine(reader.Name);
            }

            //System.Diagnostics.Debug.WriteLine(list.);

            return list;
        }

        public Hero getHero()
        {
            Hero hero = new Hero();

            return hero;
        }
    }
}
