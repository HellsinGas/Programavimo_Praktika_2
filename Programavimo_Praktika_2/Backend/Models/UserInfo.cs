using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programavimo_Praktika_2.Backend.Models
{
    public class UserInfo
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Group { get; private set; }
        public string Email { get; private set; }
        public string Role { get; private set; }


        public List<UserInfo> Userslist { get; private set; }

        public UserInfo(int id, string name , string surname , string username, string password, string group , string email, string role)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
            Group = group;
            Email = email;
            Role = role;
        }

        public void SetItems(List<UserInfo> userinfo)
        {
            Userslist = userinfo;
        }
    }
}
