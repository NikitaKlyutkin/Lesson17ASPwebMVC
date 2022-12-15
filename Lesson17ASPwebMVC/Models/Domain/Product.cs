using System;
using System.Numerics;

namespace Lesson17ASPwebMVC.Models.Domain
{
    public class Product
    {

        public Guid Id { get; set; }
        public string _name { get; set; }
        public int _quantity { get; set; }
        public decimal _price { get; set; }

        public Product() { }

        public Product(Guid id,string name, int quantity, decimal price)
        {
            Id = id;
            _name = name;
            _quantity = quantity;
            _price = price;
        }
    }
}
