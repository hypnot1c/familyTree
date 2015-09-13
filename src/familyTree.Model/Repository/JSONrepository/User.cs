using familyTree.Model.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace familyTree.Model
{
  public partial class JSONrepository : IRepository
  {
    public IEnumerable<User> Users
    {
      get
      {
        return db["Users"].ToObject<IEnumerable<User>>();
      }
      set
      {

      }
    }

    public bool CreateUser(User instance)
    {
      //if (instance.rowId == 0)
      //{
      //  instance.addedDate = DateTime.Now;
      //  instance.activatedLink = User.GetActivateUrl();
      //  db.Users.Add(instance);
      //  db.SaveChanges();
      //  return true;
      //}

      return false;
    }

    public bool UpdateUser(User instance)
    {
      //User cache = db.Users.Where(p => p.rowId == instance.rowId).FirstOrDefault();
      //if (cache != null)
      //{
      //  cache.avatarPath = instance.avatarPath;
      //  cache.email = instance.email;
      //  db.SaveChanges();
      //  return true;
      //}

      return false;
    }

    public bool RemoveUser(int idUser)
    {
      //User instance = db.Users.Where(p => p.rowId  == idUser).FirstOrDefault();
      //if (instance != null)
      //{
      //  db.Users.Remove(instance);
      //  db.SaveChanges();
      //  return true;
      //}

      return false;
    }

  }
}