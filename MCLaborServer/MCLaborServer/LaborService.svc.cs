using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MCLaborServer
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in Web.config and in the associated .svc file.
    public class LaborService : ILaborService
    {
        public string GetMessage()
        {
            return "Hello from WCF Service";
        }
    }
}
