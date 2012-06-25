USE MCLabor;
GO

IF EXISTS(SELECT object_id FROM Sys.Procedures WHERE name='EMP_LABOR_DETAIL')
BEGIN
	DROP PROCEDURE EMP_LABOR_DETAIL
END
GO

CREATE PROCEDURE EMP_LABOR_DETAIL
	@StartDate Date,
	@EndDate Date
AS    
BEGIN
	SELECT	e.employeeId, e.firstName, e.lastName, e.refCode as employeeRefCode,
		ws.workSiteName, ws.refCode as workSiteRefCode, 
		j.jobName, j.refCode as jobRefCode, 
		dtl.laborCalendarDate, dtl.laborStartDateTime, dtl.laborEndDateTime, dtl.laborStartUTCDateTime, dtl.laborEndUTCDateTime,
		CAST((CAST(DateDiff(minute, dtl.laborStartUTCDateTime, dtl.laborEndUTCDateTime) AS DECIMAL) / CAST (60 AS DECIMAL)) AS DECIMAL(10,2)) as hoursWorked
	FROM	employee e, work_site ws, job j, labor_detail dtl
	WHERE	dtl.employeeId = e.employeeId AND dtl.workSiteId = ws.workSiteId AND dtl.jobId = j.jobId
	AND		dtl.laborEndUTCDateTime IS NOT NULL
	AND		dtl.laborCalendarDate BETWEEN @StartDate AND @EndDate
END;
