using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavProjesi
{
    public interface IUsers
    {
         int UserId { get; }
         string UserName { get; set; }
         string Name { get; set; }
         string Surname { get; set; }
         string Email { get;  }
         string Password { get;  }
    
    }
}
