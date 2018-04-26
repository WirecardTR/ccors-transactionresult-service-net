using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ccors_transactionresult_service_net
{
    [Serializable]
    public class Response
    {
        public int StatusCode { get; set; }
        public string ResultCode { get; set; }
        public string ResultMessage { get; set; }
    }
}