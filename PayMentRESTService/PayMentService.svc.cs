using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PayMentRESTService
{
    
    public class PayMentService : IPayMentService
    {
        //concrete method
        public string PayBill(string PayId)
        {
            return "Transaction having PayId " + PayId + " was successful";
        }
    }
}
