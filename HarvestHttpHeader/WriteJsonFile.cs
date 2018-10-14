using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace HarvestHttpHeader
{
  class WriteJsonFile
  {
    private List<Target> targets;

    private string fileName;


    public WriteJsonFile(string fileName)
    {
      this.fileName = fileName;
    }


    public bool WriteList(List<ScanResult> outputList)
    {
      try
      {
        using (StreamWriter fsw = new StreamWriter(this.fileName))
        {
          foreach (var item in outputList)
          {
            var line = JsonConvert.SerializeObject(item);
            fsw.WriteLine(outputList);
          }
        }
      }
      catch (Exception e)
      {
        Console.Error.WriteLine(e.Message);
        return false;
      }
      return true;
    }
  }
}
