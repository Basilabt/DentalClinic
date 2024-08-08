

-----> Medical Records View

CREATE VIEW MedicalRecordsView AS

SELECT MedicalRecordID , Appointments.AppointmentID , Prescriptions.PrescriptionID ,   People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName AS Patient , Appointments.AppointmentDate , DoctorsInfo.FirstName + ' ' + DoctorsInfo.LastName AS Doctor , MedicalRecords.Description , MedicalRecords.Diagnosis 
FROM
MedicalRecords INNER JOIN Prescriptions ON MedicalRecords.PrescriptionID = Prescriptions.PrescriptionID
INNER JOIN Appointments ON MedicalRecords.AppointmentID = Appointments.AppointmentID
INNER JOIN Patients ON Patients.PatientID = Appointments.PatientID
INNER JOIN People ON Patients.PersonID = People.PersonID
INNER JOIN Doctors  ON Doctors.DoctorID = Appointments.DoctorID
INNER JOIN People AS DoctorsInfo ON Doctors.PersonID = DoctorsInfo.PersonID


-----> SP get patient medical records by fullname

CREATE PROCEDURE SP_GetPatientMedicalRecordsByFullName
	@patientFullname NVARCHAR(50)
AS
BEGIN

	SELECT MedicalRecordsView.MedicalRecordID  ,  MedicalRecordsView.Patient , MedicalRecordsView.AppointmentDate , MedicalRecordsView.Doctor , MedicalRecordsView.Description , MedicalRecordsView.Diagnosis , Prescriptions.MedicationName , Prescriptions.Dosage , Prescriptions.Frequency , Prescriptions.StartDate , Prescriptions.EndDate , Prescriptions.SpecialInstructions
	FROM MedicalRecordsView INNER JOIN Prescriptions ON MedicalRecordsView.PrescriptionID = Prescriptions.PrescriptionID
	WHERE MedicalRecordsView.Patient = @patientFullname;


END 


--------> SP get patients medical records

CREATE PROCEDURE SP_GetPatientsMedicalRecords
AS 
BEGIN
	SELECT MedicalRecordsView.MedicalRecordID ,  MedicalRecordsView.Patient , MedicalRecordsView.AppointmentDate , MedicalRecordsView.Doctor , MedicalRecordsView.Description , MedicalRecordsView.Diagnosis , Prescriptions.MedicationName , Prescriptions.Dosage , Prescriptions.Frequency , Prescriptions.StartDate , Prescriptions.EndDate , Prescriptions.SpecialInstructions
	FROM MedicalRecordsView INNER JOIN Prescriptions ON MedicalRecordsView.PrescriptionID = Prescriptions.PrescriptionID;

END





-------> SP Delete Medical Record By ID

CREATE PROCEDURE SP_DeleteMedicalRecordByID
	@medicalRecordID INT
AS
BEGIN

	DELETE 
	FROM MedicalRecords
	WHERE MedicalRecords.MedicalRecordID = @medicalRecordID;

END



-----> SP Find Patient Medical Record By Medical Record ID

CREATE PROCEDURE SP_FindMedicalRecordByID
	@medicalRecordID INT 
AS
BEGIN


	SELECT MedicalRecordsView.MedicalRecordID ,  MedicalRecordsView.Patient , MedicalRecordsView.AppointmentDate , MedicalRecordsView.Doctor , MedicalRecordsView.Description , MedicalRecordsView.Diagnosis , Prescriptions.MedicationName , Prescriptions.Dosage , Prescriptions.Frequency , Prescriptions.StartDate , Prescriptions.EndDate , Prescriptions.SpecialInstructions
	FROM MedicalRecordsView INNER JOIN Prescriptions ON MedicalRecordsView.PrescriptionID = Prescriptions.PrescriptionID
	WHERE MedicalRecordsView.MedicalRecordID = @medicalRecordID;


END 


------> SP Add New Medical Record

CREATE PROCEDURE SP_AddNewMedicalRecord
	@appointmentID INT , 
	@prescriptionID INT , 
	@description NVARCHAR(50) , 
	@diagnosis NVARCHAR(50) , 
	@additionalNotes NVARCHAR(50)
AS 
BEGIN

	INSERT INTO MedicalRecords(AppointmentID,PrescriptionID,Description,Diagnosis,AdditionalNotes)
	VALUES(@appointmentID,@prescriptionID,@description,@diagnosis,@additionalNotes);


END 





