using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.domain.Entities;

namespace UserApp.application.DTOs.Users
{
    public class UserDto
    {

        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

        public static UserDto FromEntity(User u)
        {
            return new UserDto
            {

                Name = u.Name,
                Username = u.Username,
                Email = u.Email,
                IsActive = u.IsActive
            };
        }
    }
}
