using ProductProject.API.Data;
using ProductProject.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductProject.API.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _db;
        public ProductService(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<Product> GetAll()
        {
            var productsList = _db.Products.ToList();
            return productsList;
        }
        public Product Get(int Id)
        {
            var productId = _db.Products.Find(Id);
            return productId;
        }
    }
}
