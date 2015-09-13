using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using familyTree.Model;
using Newtonsoft.Json;
using familyTree.Model.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace familyTree.Controllers
{
  public class UserController : BaseController
  {

    public UserController(IRepository db)
    {
      this.db = db;
    }
    // GET: /<controller>/
    public IActionResult Index()
    {
      var users = db.Users.ToList();
      return View(users);
    }
  }
}
