using AutoMapper;
using DeveloperStore.Data.DTO;
using DeveloperStore.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperStore.Data.AutoMapper
{
    public class VendaProfile : Profile
    {
        public VendaProfile()
        {
            CreateMap<VendaDTO, Venda>();
            CreateMap<Venda, VendaDTO>();
        }
    }
}
