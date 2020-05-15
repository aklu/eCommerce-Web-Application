using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HappyPaws.Models;

namespace HappyPaws.Controllers
{
    public class Item
    {
        private Toy toy = new Toy();
        private int quantity;

        public Toy Toy
        {
            get { return toy; }
            set { toy = value; }
        }

        public Item(Toy toys, int quantity)
        {
            this.toy = toys;
            this.Quantity = quantity;

        }

        public int Quantity { get => quantity; set => quantity = value; }
    }
}