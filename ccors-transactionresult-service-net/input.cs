using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ccors_transactionresult_service_net
{
    public class input
    {
       
      public int StatusCode { get; set; }
      public string ResultCode { get; set; }
      public string ResultMessage { get; set; }
      public Guid OrderId { get; set; }
      public string MPAY { get; set; } 
      public double Price { get; set; }
      public DateTime TransactionDate { get; set; } 
      public string ServiceTypeCode { get; set; } 
      public string TransactionTypeCode { get; set; }
      public string ExtraParam { get; set; }
    }
}