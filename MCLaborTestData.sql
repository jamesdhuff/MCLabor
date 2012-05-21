insert into EMPLOYEE(refCode, firstName, middleName, lastName, loginId, address, city, state, zip, ssn, primaryPhone, alternatePhone,
					emergencyContactName, emergencyContactRelationship, emergencyContactAddress, emergencyContactCity, 
					emergencyContactState, emergencyContactZip, emergencycontactphone)
				VALUES ('MC99','Test','J','McTesterson',99,'123 Nowhere Street','Nowhere','MI',49720,'987-65-4321','231-987-6543','231-456-7890',
						'Mrs McTesterson', 'Wife', '123 Nowhere Street', 'Nowhere', 'MI', 49720, '231-675-8490');
						
insert into JOB(refCode, jobName, description) VALUES ('GEN','General Labor','Used for all general labor, including site prep, loading and unloading, and yard work.');
insert into JOB(refCode, jobName, description) VALUES ('FIN','Finisher','Finisher');
insert into JOB(refCode, jobName, description) VALUES ('EST','Estimator','Estimator');
insert into JOB(refCode, jobName, description) VALUES ('FOR','Foreman','Foreman');
insert into JOB(refCode, jobName, description) VALUES ('MGR','Office Manager','Office Manager');

insert into WORK_SITE(refCode, workSiteName, description) VALUES('YRD', 'Yard', 'MCLabor Headquarters Workyard');

insert into PAY_RATE(employeeId, jobId, hourlyPayRate) VALUES (1,1,15.50);

insert into EMP_HIRE_STATUS(employeeId, status) VALUES(1,0);

						