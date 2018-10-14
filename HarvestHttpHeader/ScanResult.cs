using System.Collections.Generic;
using System;

namespace HarvestHttpHeader
{
  class ScanResult
  {
    public Dictionary<string, string> headers = new Dictionary<string, string>();
    //public List<KeyValuePair<string, string>> headers = new List<KeyValuePair<string, string>>();
    //public List<string> headers = new List<string>();
    public string label;
    //timestamp --meh
  }
}
