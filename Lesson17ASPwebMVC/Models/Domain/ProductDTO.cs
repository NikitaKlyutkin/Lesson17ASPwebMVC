using System;
using System.Runtime.InteropServices.ComTypes;

namespace Lesson17ASPwebMVC.Models.Domain
{
    public class ProductDTO
    {
        public Guid IdDTO { get; set; }
        public string _name { get; set; }
        public int _quantity { get; set; }
        public decimal _price { get; set; }
    }
}
