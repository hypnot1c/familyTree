using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using familyTree.Model.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace familyTree.Model
{
  // This project can output the Class library as a NuGet Package.
  // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
  public partial class JSONrepository : IRepository
  {

    public JObject db;

    public JSONrepository(string dbFilePath)
    {
      using (var file = new FileStream(path: dbFilePath, mode: FileMode.Open))
      {
        using (var reader = new StreamReader(file))
        {
          using (var jr = new JsonTextReader(reader))
          {
            var se = new JsonSerializer();
            this.db = se.Deserialize(jr) as JObject;
          }
        }
      }
    }
  }
}
