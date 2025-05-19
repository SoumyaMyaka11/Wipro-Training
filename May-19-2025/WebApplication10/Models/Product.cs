namespace WebApplication10.Models
{
    public class Product
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Category Category { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryType { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
