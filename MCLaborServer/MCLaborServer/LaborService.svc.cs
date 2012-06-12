using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MCLaborLib;
using log4net;
using log4net.Config;
using System.IO;

namespace MCLaborServer
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in Web.config and in the associated .svc file.
    public class LaborService : ILaborService
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public string GetMessage()
        {
            return "Hello from Labor Service";
        }

        public bool isValidLogin(int loginId)
        {
            using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT employeeId FROM employee WHERE loginId = @loginId", conn))
                {
                    cmd.Parameters.AddWithValue("@loginId", loginId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        public Employee getEmployee(int loginId)
        {
            Employee emp = new Employee();
            TimeCard tc = new TimeCard();

            logger.Debug("getEmployee() called for loginId " + loginId);
                
            try
            {
                using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT	TOP 1 e.employeeId, e.refCode, e.firstName, e.lastName, " +
                                                            "		CASE WHEN (l.laborEndUtcDateTime IS NULL AND l.laborStartUtcDateTime IS NOT NULL) " +
                                                            "           THEN 1 ELSE 0 END AS isClockedIn " +
                                                            "FROM	employee e " +
                                                            "LEFT OUTER JOIN labor_detail l " +
                                                            "ON	    e.employeeId = l.employeeId " +
                                                            "WHERE  (l.laborStartUtcDateTime IS NULL OR l.laborStartUtcDateTime < getUtcDate()) " +
                                                            "AND	e.loginId = @loginId  " +
                                                            "ORDER BY l.laborStartUtcDateTime desc", conn))
                    {
                        cmd.Parameters.AddWithValue("@loginId", loginId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                emp.EmployeeId = reader.GetInt32(0);
                                emp.RefCode = reader.GetString(1);
                                emp.FirstName = reader.GetString(2);
                                emp.LastName = reader.GetString(3);
                                emp.IsClockedIn = (reader.GetInt32(4) == 1) ? true : false;
                            }
                        }
                    }                   
                }
            }
            catch (Exception e)
            {
                logger.Error(e.ToString());
            }

            return emp;
        }


        public List<WorkSite> getWorkSiteList()
        {
            try
            {
                List<WorkSite> workSiteList = new List<WorkSite>();

                using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT workSiteId, workSiteName, refCode FROM work_site WHERE active = 1", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                WorkSite ws = new WorkSite();
                                ws.WorkSiteId = reader.GetInt32(0);
                                ws.WorkSiteName = reader.GetString(1);
                                ws.RefCode = reader.GetString(2);
                                ws.Active = true;

                                workSiteList.Add(ws);
                            }
                        }
                    }
                }

                return workSiteList;
            }
            catch (Exception ex)
            {
                logger.Error("Exception during call to getWorkSiteList()");
                logger.Error(ex.ToString());
                throw;
            }
        }


        public List<Job> getJobList(int employeeId)
        {            
            try
            {
                List<Job> jobList = new List<Job>();

                using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT j.jobId, j.jobName, j.refCode " +
                                                            "FROM pay_rate p, job j " +
                                                            "WHERE p.jobId = j.jobId " +
                                                            "AND p.active = 1 " +
                                                            "AND p.employeeId = @employeeId " +
                                                            "ORDER BY j.jobName", conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", employeeId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Job j = new Job();
                                j.JobId = reader.GetInt32(0);
                                j.JobName = reader.GetString(1);
                                j.RefCode = reader.GetString(2);

                                jobList.Add(j);
                            }
                        }
                    }
                }

                return jobList;
            }
            catch (Exception ex)
            {
                logger.Error("Exception during call to getJobList()");
                logger.Error(ex.ToString());
                throw; 
            }            
        }

        public TimeCard getLatestOpenTimeCard(int employeeId)
        {
            try
            {
                TimeCard tc = new TimeCard();

                using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 1 " +
                                                "	laborDetailId, laborCalendarDate, " +
                                                "	laborStartDateTime, laborStartUtcDateTime, " +
                                                "	w.workSiteId, w.workSiteName, w.refCode, " +
                                                "	j.jobId, j.jobName, j.refCode " +
                                                "FROM labor_detail l, work_site w, job j " +
                                                "WHERE l.workSiteId = w.workSiteId AND j.jobId = l.jobId " +
                                                "AND laborStartUtcDateTime < GETUTCDATE() " +
                                                "AND laborEndUtcDateTime IS NULL " +
                                                "AND l.employeeId = @employeeId " +
                                                "ORDER BY laborStartUtcDateTime DESC", conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", employeeId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tc.LaborDetailId = reader.GetInt32(0);
                                tc.CalendarDate = reader.GetDateTime(1);
                                tc.LocalStartTime = reader.GetDateTime(2);
                                tc.UtcStartTime = reader.GetDateTime(3);

                                WorkSite ws = new WorkSite();
                                ws.WorkSiteId = reader.GetInt32(4);
                                ws.WorkSiteName = reader.GetString(5);
                                ws.RefCode = reader.GetString(6);
                                tc.WorkSite = ws;

                                Job j = new Job();
                                j.JobId = reader.GetInt32(7);
                                j.JobName = reader.GetString(8);
                                j.RefCode = reader.GetString(9);
                                tc.Job = j;
                            }
                            else
                            {
                                //TODO throw some FaultException
                            }
                        }
                    }
                }

                return tc;
            }
            catch (Exception ex)
            {
                logger.Error("Exception during call to getLatestTimeCard()");
                logger.Error(ex.ToString());
                throw; 
            }
        }


        public void doClockIn(TimeCard tc)
        {
            string sqlString = "INSERT INTO labor_detail " +
                               "    (employeeId, workSiteId, jobId, laborCalendarDate, laborStartDateTime, laborEndDateTime, laborStartUtcDateTime, laborEndUtcDateTime) " +
                               "VALUES " +
                               "    (@employeeId, @workSiteId, @jobId, @calendarDate, @startTime, @endTime, @startUtcTime, @endUtcTime); " +
                               "SELECT cast(Scope_Identity() as int)";

            try
            {
                using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                    {
                        cmd.Parameters.AddWithValue("@employeeId", tc.Employee.EmployeeId);
                        cmd.Parameters.AddWithValue("@workSiteId", tc.WorkSite.WorkSiteId);
                        cmd.Parameters.AddWithValue("@jobId", tc.Job.JobId);
                        cmd.Parameters.AddWithValue("@calendarDate", DateTime.Today);
                        cmd.Parameters.AddWithValue("@startTime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@endTime", DBNull.Value);
                        cmd.Parameters.AddWithValue("@startUtcTime", DateTime.UtcNow);
                        cmd.Parameters.AddWithValue("@endUtcTime", DBNull.Value);

                        tc.LaborDetailId = (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error("Exception during call to doClockIn()");
                logger.Error(ex.ToString());
                throw;
            }
        }

        public void doClockOut(TimeCard tc)
        {
            string sqlString = "UPDATE labor_detail SET laborEndDateTime = @endTime, laborEndUtcDateTime = @endUtcTime " + 
                                "WHERE employeeId = @employeeId AND laborDetailId = @laborDetailId";
            try
            {
                using (SqlConnection conn = DBUtils.getConnection("MCLabor"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                    {
                        cmd.Parameters.AddWithValue("@endTime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@endUtcTime", DateTime.UtcNow);
                        cmd.Parameters.AddWithValue("@employeeId", tc.Employee.EmployeeId);
                        cmd.Parameters.AddWithValue("@laborDetailId", tc.LaborDetailId);

                        int result = cmd.ExecuteNonQuery();
                        if (result < 1)
                        {
                            //TODO throw some FaultException because no rows were affected
                            logger.Error("No records affected during execution of doClockOut().  LaborDetailId = " + tc.LaborDetailId + ", EmployeeId = " + tc.Employee.EmployeeId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error("Exception during call to doClockOut()");
                logger.Error(ex.ToString());
                throw;
            }
        }
    }
}
