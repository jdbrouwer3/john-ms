using AutoMapper;
using MovieNight.Data.Entities;
using dom = MovieNight.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Data.Helpers
{
    public static class DomainHelper
    {
        //have all the mappings that we need
        public static MapperConfiguration addressMapper = new MapperConfiguration(mc =>
            mc.CreateMap<Address, dom.Address>()
                .ForMember(m => m.Id, u => u.MapFrom(src => src.AddressId))
                .ForMember(m => m.Country.Name, u => u.MapFrom(src => src.Country))
                .ForMember(m => m.Country.Code, u => u.NullSubstitute("US")));

        public static MapperConfiguration nameMapper = new MapperConfiguration(mc =>
            mc.CreateMap<User, dom.Name>()
                .ForPath(m => m.Prefix.Name, u => u.MapFrom(src => src.Prefix))
                .ForMember(m => m.First, u => u.MapFrom(src => src.First))
                .ForMember(m => m.Last, u => u.MapFrom(src => src.Last)));

        //write all else e.i. genre
    }
}
