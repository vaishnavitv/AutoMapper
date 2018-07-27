using AutoMapper;
using System;

namespace AutoMapperDemo
{
   public class InputToOutputProfile : Profile
    {
        public InputToOutputProfile()
        {
            this.CreateMap<InputOrder, OutputOrder>()
                .ForMember(dest => dest.OrderCreatedDateTime, opt => opt.Ignore());
               // .AfterMap;
        }
    }
}
