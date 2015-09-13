using familyTree.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace familyTree.Model
{
  public interface IRepository
  {
    IEnumerable<User> Users { get; set; }

    bool CreateUser(User instance);
    bool UpdateUser(User instance);
    bool RemoveUser(int idUser);
  }
}
