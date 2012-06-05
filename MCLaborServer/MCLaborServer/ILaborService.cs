using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MCLaborServer
{
    // NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in Web.config.
    [ServiceContract]
    public interface ILaborService
    {

        [OperationContract]
        string GetMessage();

        // TODO: Add your service operations here
    }
}
