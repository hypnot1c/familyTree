using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace familyTree.Model.Models
{
  public partial class User
  {
    public int rowId { get; set; }
    public string email { get; set; }
    //public string password { get; set; }
    public DateTime addedDate { get; set; }
    //public DateTime? activatedDate { get; set; }
    //public string activatedLink { get; set; }
    //public DateTime? lastVisitDate { get; set; }
    //public string avatarPath { get; set; }
  }
}
