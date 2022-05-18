using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavProjesi
{
    public class User : IUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }

        public User(int UserId, string UserName, string Name, string Surname, string Email, string Password)
        {
            this.UserId = UserId;
            this.UserName = UserName;
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Password = Password;
        }
    }
}

