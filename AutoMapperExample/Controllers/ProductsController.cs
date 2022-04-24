using AutoMapper;
using AutoMapperExample.Data;
using AutoMapperExample.Dtos;
using AutoMapperExample.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AutoMapperExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IRepository<Product> repository;
        private readonly IMapper mapper;
        public ProductsController(IRepository<Product> _repository,IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var productList = repository.GetAll();
            var productDtoList = mapper.Map<List<ProductDto>>(productList);
            return Ok(productDtoList);
        }
        [HttpPost]
        public ActionResult Add([FromBody]Product product)
        {
            if (product == null)
                return BadRequest();
            else
            {
                repository.Add(product);
                repository.SaveAll();
                return Ok(product);
            }
        }
    }
}
