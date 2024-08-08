

-----> Create Payments View


ALTER VIEW PaymentsView AS
SELECT 
    People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName AS Patient, 
	 DoctorPeople.FirstName + ' ' + DoctorPeople.SecondName + ' ' + DoctorPeople.ThirdName + ' ' + DoctorPeople.LastName AS Doctor ,
    Appointments.AppointmentDate, 
    Appointments.AppointmentTime, 
    Payments.PaidAmount, 
    PaymentMethods.PaymentMethod
   
FROM 
    Appointments 
INNER JOIN 
    Payments ON Appointments.AppointmentID = Payments.AppointmentID
INNER JOIN 
    PaymentMethods ON Payments.PaymentMethodID = PaymentMethods.PaymentMethodID
INNER JOIN 
    Patients ON Appointments.PatientID = Patients.PatientID
INNER JOIN 
    People ON Patients.PersonID = People.PersonID
INNER JOIN 
    Doctors ON Appointments.DoctorID = Doctors.DoctorID
INNER JOIN 
    People AS DoctorPeople ON Doctors.PersonID = DoctorPeople.PersonID;




------> SP Get All Payments 

CREATE PROCEDURE SP_GetAllPaymnets 
AS
BEGIN 

	SELECT * 
	FROM PaymentsView;

END


------> SP Add New Payment 


ALTER PROCEDURE SP_AddNewPayment

	@appointmentID INT , 
	@paymentDate DATE , 
	@paidAmount FLOAT , 
	@paymentMethodID INT , 
	@additionalNotes NVARCHAR(50)
AS
BEGIN

	INSERT INTO Payments(PaymentDate,PaidAmount,PaymentMethodID,AdditionalNotes,AppointmentID)
	VALUES (@paymentDate,@paidAmount,@paymentMethodID,@additionalNotes,@appointmentID);

END 

