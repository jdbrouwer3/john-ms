using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using MovieNight.Data.Entities;
using dm = MovieNight.Domain.Models;

namespace MovieNight.Data.Helpers
{
    public class UserHelper
    {
        private MovieNightDbContext _db = new MovieNightDbContext;

        private MapperConfiguration userMap = new MapperConfiguration(mc =>
            mc.CreateMap<User, dm.User>()
                .ForMember(m => m.Id, u => u.MapFrom(s => s.UserId))
                .ForMember(m => m.Name, u => u.MapFrom(src => DomainHelper.nameMapper))
                .ForMember(m => m.Address, u => u.MapFrom(src => DomainHelper.addressMapper)));

        public List<dm.User> GetUsers()
        {
            var userList = new List<dm.User>();
            var mapper = userMap.CreateMapper();

            foreach (var item in _db.User.ToList())
            {
                userList.Add(mapper.Map<dm.User>(item));
            }

            return userList;
        }
    }
}
