using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MCLaborLib;

namespace MCLaborServer
{
    [ServiceContract]
    public interface ILaborService
    {
        [OperationContract]
        string GetMessage();

        [OperationContract]
        bool isValidLogin(int loginId);

        [OperationContract]
        Employee getEmployee(int loginId);

        [OperationContract]
        List<WorkSite> getWorkSiteList();

        [OperationContract]
        List<Job> getJobList(int employeeId);

        [OperationContract]
        TimeCard getLatestOpenTimeCard(int employeeId);

        [OperationContract]
        void doClockOut(TimeCard tc);

        [OperationContract]
        void doClockIn(TimeCard tc);

    }
}
