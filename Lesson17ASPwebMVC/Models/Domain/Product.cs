namespace Lesson17ASPwebMVC.Models.Domain
{
    public class Product
    {
        public string _name { get; set; }
        public int _quantity { get; set; }
        public decimal _price { get; set; }

        public Product() { }

        public Product(string name, int quantity, decimal price)
        {
            _name = name;
            _quantity = quantity;
            _price = price;

        }
    }
}
