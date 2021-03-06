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
          var serializedList = JsonConvert.SerializeObject(outputList);
          fsw.WriteLine(serializedList);
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
