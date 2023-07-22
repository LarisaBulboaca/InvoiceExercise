using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceExercise
{
    internal class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public Item(int id, string name, string description, int price, int quantity) 
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;

        }

    }
}
