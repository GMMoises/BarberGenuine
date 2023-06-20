using APIBarberGenuine.Models;
using APIBarberGenuine.Models.Dto;
using AutoMapper;

namespace APIBarberGenuine
{
    public class MappingConfig:Profile
    {
        public MappingConfig()
        {
            //Mapeo de Cita
            CreateMap<Cita, CitaDto>().ReverseMap();
            CreateMap<Cita, CitaCreateDto>().ReverseMap();
            CreateMap<Cita, CitaUpdateDto>().ReverseMap();
            //Mapeo de Client
            CreateMap<Client, ClientDto>().ReverseMap();
            CreateMap<Client,ClientCreateDto>().ReverseMap();
            CreateMap<Client,ClientUpdateDto>().ReverseMap();
            //Mapeo de Product
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product,ProductCreateDto>().ReverseMap();
            CreateMap<Product, ProductUpdateDto>().ReverseMap();
            //Mapeo de Factura
            CreateMap<Factura, FacturaDto>().ReverseMap();
            CreateMap<Factura, FacturaCreateDto>().ReverseMap();
            CreateMap<Factura, FacturaUpdateDto>().ReverseMap();
        }
    }
}
