using ProductProject.API.Data;
using ProductProject.API.Dto;
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
        public void Delete(int Id)
        {
            var productDelete = _db.Products.Find(Id);
            _db.Products.Remove(productDelete);
            _db.SaveChanges();
        }
        public int Create(CreateDto dto)
        {
            var product = new Product();
             product.Name =dto.Name;
            product.Cost = dto.Cost;    
            product.Price = dto.Price;

            _db.Products.Add(product);
            _db.SaveChanges();
            return product.Id;

        }
        public int Update(UpdateDto dto)
        {
            var productUpdate = _db.Products.Find(dto.Id);
            productUpdate.Id = dto.Id;
            productUpdate.Name = dto.Name;
            productUpdate.Cost = dto.Cost;
            productUpdate.Price = dto.Price;

            _db.Products.Update(productUpdate);
            _db.SaveChanges();
            return productUpdate.Id;
        }

    }
}
