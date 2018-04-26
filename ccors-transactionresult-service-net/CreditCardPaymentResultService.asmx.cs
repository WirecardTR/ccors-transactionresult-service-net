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
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CreditCardPaymentResultService : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true)]
        public Response ReceiveTransactionResult(int StatusCode, string ResultCode, string ResultMessage, string OrderId, string MPAY, double Price, DateTime TransactionDate, string ServiceTypeCode, string TransactionTypeCode, string ExtraParam)
        {
            Response response = new Response();
            response.StatusCode = 0;
            response.ResultCode = string.Empty;
            response.ResultMessage = string.Empty;
            return response;
        }
    }
}
