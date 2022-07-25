using ProductProject.API.Dto;
using ProductProject.API.Models;
using System.Collections.Generic;

namespace ProductProject.API.Services
{
    public interface IProductService
    {
        Product Get(int Id);
        List<Product> GetAll();
        void Delete(int Id);
        int Create(CreateDto dto);
        int Update(UpdateDto dto);
    }
}