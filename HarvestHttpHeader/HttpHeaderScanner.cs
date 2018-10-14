using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvestHttpHeader
{
  class HttpHeaderScanner
  {
    private List<Target> targets;
    private List<ScanResult> scanResultList = new List<ScanResult>();
    private bool errorFlag;

    // constructor
    public HttpHeaderScanner(List<Target> targets)
    {
      this.targets = targets;
    }

    public Boolean Scan()
    {
      using (WebClient client = new WebClient())
      {
        foreach (var target in targets)
        {
          try
          {
            //this should be AsynChrouns
            // should be like --> ExceuteAsyncHeaderScan();
            client.Proxy = null;
            client.DownloadString(target.address);
          }
          catch
          {
            errorFlag = true;
          }
          var scanResult = new ScanResult();
          if (client.ResponseHeaders != null)
          {
            foreach (string header in client.ResponseHeaders.Keys)
            {
              scanResult.headers.Add(header);
              scanResult.label = target.label;
            }
            //push the result to the list
            scanResultList.Add(scanResult); // --> Could be the same for async
          }
        }
      }
      return errorFlag ? false : true;
    }

    public List<ScanResult> GetScanResults()
    {
      return scanResultList;
    }
  }
}
