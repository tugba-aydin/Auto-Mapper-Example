using AutoMapper;
using AutoMapperExample.Dtos;
using AutoMapperExample.Entities;

namespace AutoMapperExample.Helpers
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductDto>();
        }
    }
}
