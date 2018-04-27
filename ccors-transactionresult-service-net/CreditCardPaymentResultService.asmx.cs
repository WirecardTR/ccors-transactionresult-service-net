using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ccors_transactionresult_service_net
{
    /// <summary>
    /// Summary description for CreditCardPaymentResultService
    /// </summary>
    [WebService(Namespace = "http://cservices.mikro-odeme.com.tr/mapping/generated")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
  
    public class CreditCardPaymentResultService : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        public Response ReceiveTransactionResult(input input)
        {
            Response response = new Response();
            response.StatusCode = 0;
            response.ResultCode = string.Empty;
            response.ResultMessage = string.Empty;
            return response;
        }
    }
}
