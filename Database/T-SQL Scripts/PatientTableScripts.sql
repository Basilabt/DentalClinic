-----> SP Does Patient Exist

CREATE PROCEDURE SP_DoesPatientExist

	@FirstName  NVARCHAR(50)  ,
	@SecondName NVARCHAR(50)  ,
	@ThirdName  NVARCHAR(50)  ,
	@LastName   NVARCHAR(50)  
AS
BEGIN

	SELECT IsFound = 1
	FROM Patients INNER JOIN People ON Patients.PersonID = People.PersonID
	WHERE People.FirstName = @FirstName AND People.SecondName = @SecondName AND People.ThirdName = @ThirdName AND People.LastName = @LastName
	
END 


----> Patient View 

CREATE VIEW PatientsView
AS
SELECT Patients.PatientID , People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName AS Name , People.Gender , People.BirthDate
FROM Patients INNER JOIN People ON Patients.PersonID = People.PersonID;


-----> SP Get all patients


CREATE PROCEDURE SP_GetAllPatients
AS
BEGIN

		SELECT *
		FROM PatientsView;
	

END


----> SP Add New Patient

CREATE PROCEDURE SP_AddNewPatient
	@PersonID INT 
AS
BEGIN

	INSERT INTO Patients(PersonID) 
	VALUES(@PersonID);

END



------> SP Find Patient 

CREATE PROCEDURE SP_FindPatient
	@FirstName	NVARCHAR(50) , 
	@SecondName NVARCHAR(50) , 
	@ThirdName  NVARCHAR(50)  , 
	@LastName   NVARCHAR(50) 
AS
BEGIN

	SELECT *
	FROM Patients INNER JOIN People ON Patients.PersonID = People.PersonID
	WHERE People.FirstName = @FirstName AND People.SecondName = @SecondName AND People.ThirdName = @ThirdName AND People.LastName = @LastName;

END


-----> SP Delete Patient 

CREATE PROCEDURE SP_DeletePatient
	@PatientID INT
AS
BEGIN 

	DELETE 
	FROM Patients
	WHERE Patients.PatientID = @PatientID;

END 


----> SP Find Patient By ID 

CREATE PROCEDURE SP_FindPatientByID
	@PatientID INT 
AS
BEGIN

	SELECT * 
	FROM Patients
	WHERE Patients.PatientID = @PatientID

END 


