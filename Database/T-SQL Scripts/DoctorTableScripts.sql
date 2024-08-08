
--> Creating View To Use In DGV

CREATE VIEW DoctorsView 
AS
SELECT People.PersonID , 'Dr. ' + People.FirstName + ' ' + People.LastName AS Name , Doctors.Specialization
FROM Doctors INNER JOIN People ON Doctors.PersonID = People.PersonID;


--> SP with the View

CREATE PROCEDURE SP_GetAllDoctors
AS
BEGIN

	SELECT * FROM DoctorsView;

END



--> SP find doctor

CREATE PROCEDURE SP_FindDoctorByID
	@DoctorID INT
AS
BEGIN

	SELECT * 
	FROM Doctors
	WHERE Doctors.DoctorID = @DoctorID;

END


--> SP delete doctor

 CREATE PROCEDURE SP_DeleteDoctorByID
	@DoctorID INT
AS
BEGIN

	DELETE
	FROM Doctors
	WHERE Doctors.DoctorID = @DoctorID;


END 


--> SP add doctor 


CREATE PROCEDURE SP_AddNewDoctor
	@PersonID INT ,
	@Specialization NVARCHAR(50)
AS
BEGIN


		INSERT INTO Doctors(PersonID,Specialization) 
		VALUES(@PersonID,@Specialization);
		SELECT SCOPE_IDENTITY();


END


---> SP Get Doctor ID By Specialization

CREATE PROCEDURE SP_GetDoctorIDBySpecialization
	@Specialization NVARCHAR(50)
AS
BEGIN

SELECT TOP 1 Doctors.DoctorID
FROM Doctors
WHERE Doctors.Specialization = @Specialization;

END

