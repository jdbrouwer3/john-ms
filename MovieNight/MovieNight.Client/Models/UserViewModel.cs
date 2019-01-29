using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieNight.Client.Models
{
    public class UserViewModel ///finish this class and find/create its reference
    {
        private UserHelper _helper = new UserHelper();
        public List<Users> Users { get; set; }

        public UserViewModel()
        {
            Users = _helper
        };
    }
}
