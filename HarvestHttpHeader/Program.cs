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
      var outputFile = "D:/data/repos/VisualStudio/Projects/HarvestHttpHeader/HarvestHttpHeader/output.json";
      var jsonWriter = new WriteJsonFile(outputFile);
      var targetFile = "D:/data/repos/VisualStudio/Projects/HarvestHttpHeader/HarvestHttpHeader/targetObjects.json";
      var targets = jsonLoader.GetList(targetFile);

      var httpHeaderScanner = new HttpHeaderScanner(targets);
      httpHeaderScanner.Scan(); // should wait async --> perhaps write a dot to the screen ever x milliscenonds

      var results = httpHeaderScanner.GetScanResults();
      //reader http/https header for the requests

      foreach(var result in results)
      {
        Console.WriteLine(result.label);
        foreach(var header in result.headers)
        {
          Console.WriteLine("\t" + header);
        }
      }

      Console.WriteLine("\nDumping results to file {0} ...", outputFile);
      jsonWriter.


    }
  }
}
