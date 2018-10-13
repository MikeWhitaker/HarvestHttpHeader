using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace HarvestHttpHeader
{
  class LoadJsonFileContens
  {

    public List<Target> getList(string targetFile)
    {
      using (StreamReader r = new StreamReader(targetFile))
      {
        string json = r.ReadToEnd();
        List<Target> targets = JsonConvert.DeserializeObject<List<Target>>(json);
        return targets;
      }
    }
  }
}
