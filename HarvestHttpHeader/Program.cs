using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvestHttpHeader
{
  class Program
  {
    static void Main(string[] args)
    {
      var jsonLoader = new LoadJsonFileContens();
      var targetFile = "D:/data/repos/VisualStudio/Projects/HarvestHttpHeader/HarvestHttpHeader/targetObjects.json";
      var targets = jsonLoader.getList(targetFile);



      //reader http/https header for the requests

      foreach(var target in targets)
      {
        Console.WriteLine(target.label);
      }
    }
  }
}
