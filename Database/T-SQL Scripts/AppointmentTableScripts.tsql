

------> Appointments View 

CREATE VIEW AppointmentsView AS
SELECT 
    Appointments.AppointmentID,
    PatientPeople.FirstName + ' ' + PatientPeople.SecondName + ' ' + PatientPeople.ThirdName + ' ' + PatientPeople.LastName AS Patient,
    DoctorPeople.FirstName + ' ' + DoctorPeople.SecondName + ' ' + DoctorPeople.ThirdName + ' ' + DoctorPeople.LastName AS Doctor,
    Doctors.Specialization  , Appointments.AppointmentDate AS Date , Appointments.AppointmentTime AS Time ,  
	CASE 
		
		WHEN Appointments.AppointmentStatusID = 1 THEN 'Active' 
		ELSE 'Canceled'

	END AS Stauts 
FROM 
    Appointments
INNER JOIN 
    Patients ON Appointments.PatientID = Patients.PatientID
INNER JOIN 
    People AS PatientPeople ON Patients.PersonID = PatientPeople.PersonID
INNER JOIN 
    Doctors ON Appointments.DoctorID = Doctors.DoctorID
INNER JOIN 
    People AS DoctorPeople ON Doctors.PersonID = DoctorPeople.PersonID;



-------> SP Get All Appointments

CREATE PROCEDURE SP_GetAllAppointments
AS
BEGIN 

	SELECT * FROM AppointmentsView;


END


-----> SP Delete Appointment


CREATE PROCEDURE SP_DeleteAppointmentByID
	@AppointmentID INT 
AS
BEGIN

 DELETE 
 FROM Appointments
 WHERE Appointments.AppointmentID = @AppointmentID;

END 

-----> SP Find Appointment By ID

CREATE PROCEDURE SP_FindAppointmentByID
	@AppointmentID INT 
AS
BEGIN

	SELECT *
	FROM Appointments
	WHERE Appointments.AppointmentID = @AppointmentID;
	

END 

-----> SP Add New Appointment


CREATE PROCEDURE SP_AddNewAppointment
	@patientID INT , 
	@doctorID INT ,
	@appointmentDate DATE , 
	@appointmentTime TIME ,
	@appointmentStatusID INT

AS
BEGIN

	INSERT 
	INTO Appointments(PatientID,DoctorID,AppointmentDate,AppointmentTime,AppointmentStatusID)
	VALUES(@patientID,@doctorID,@appointmentDate,@appointmentTime,@appointmentStatusID)

END 
		
