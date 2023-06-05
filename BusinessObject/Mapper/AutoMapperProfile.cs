using AutoMapper;
using Data_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<MemberObject, Member>();
            CreateMap<ProductObject, Product>();
            CreateMap<OrderObject, Order>();
            CreateMap<OrderDetailObject, OrderDetail>();
        }
    }
}
