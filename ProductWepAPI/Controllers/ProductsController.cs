using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IProduct<Product> _repository;
        public ProductsController(IProduct<Product> repository)
        {
            _repository = repository; 
        }
        // Must decorate for swagger
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _repository.GetAll();
        }
        [HttpGet("id/{id}")]
        [Authorize]
        public Product GetById(int id)
        {
            return _repository.Get(id);
        }

        [HttpPost]
        [Authorize]
        public void Post(Product p)
        {
            _repository.Add(p);

        }

    }
}
