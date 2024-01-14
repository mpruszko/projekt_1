using Projekt_1.MVC.Models;

namespace Projekt_1.MVC.Services
{
    public class ProductService
    {
        private static int count = 5;
        private static List<Product> products =
            new List<Product>()
            {
                new Product
                {
                    Id=1,
                    Name="Phone",
                    Description="Samsung"
                },
                new Product
                {
                    Id=2,
                    Name="Laptop",
                    Description="ASUS"
                },
                new Product
                {
                    Id=3,
                    Name="Car",
                    Description="Ford"
                },
                new Product
                {
                    Id=4,
                    Name="Shoes",
                    Description="Nike"
                },
                new Product
                {
                    Id=5,
                    Name="Book",
                    Description="Some book"
                }
            };
        public List<Product> GetAll()
        {
            return products;
        }
        public Product GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
        public int GetNextId()
        {
            count++;
            return count;
        }
        public void Create(Product product)
        {
            product.Id = GetNextId();
            products.Add(product);
        }
        public void Update(Product productNew)
        {
            var product = GetById(productNew.Id);
            product.Name = productNew.Name;
            product.Description = productNew.Description;
        }
        public void Delete(int id)
        {
            products.Remove(GetById(id));
        }
    }
}
