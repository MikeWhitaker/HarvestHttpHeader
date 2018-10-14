using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace HarvestHttpHeader
{
  class LoadJsonFileContens
  {
    private List<Target> targets;

    public List<Target> GetList(string targetFile)
    {
      try
      {
        using (StreamReader r = new StreamReader(targetFile))
        {
          string json = r.ReadToEnd();
          targets = JsonConvert.DeserializeObject<List<Target>>(json);
        }
      } catch 
      {
        Console.Error.WriteLine("An error occurd while reading the input file.");
      }

      return targets;
    }
  }
}
