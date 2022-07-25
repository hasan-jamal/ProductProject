using ProductProject.API.Models;
using System.Collections.Generic;

namespace ProductProject.API.Services
{
    public interface IProductService
    {
        Product Get(int Id);
        List<Product> GetAll();
    }
}