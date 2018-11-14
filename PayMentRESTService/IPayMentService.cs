using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PayMentRESTService
{

    [ServiceContract]
    public interface IPayMentService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",UriTemplate = "/PayBill/{PayId}", BodyStyle = WebMessageBodyStyle.Wrapped,RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json)]
        string PayBill(string PayId);
       
    }
}
