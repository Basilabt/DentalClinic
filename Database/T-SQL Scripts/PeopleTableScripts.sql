CREATE PROCEDURE SP_FindPersonByPersonID
	@PersonID INT 
AS 
BEGIN

	SELECT * 
	FROM People 
	WHERE People.PersonID = @PersonID;

END 



--------------->



CREATE PROCEDURE SP_AddNewPerson
 
	@FirstName NVARCHAR(50), 
	@SecondName NVARCHAR(50), 
	@ThirdName NVARCHAR(50), 
	@LastName NVARCHAR(50), 
	@BirthDate DATE , 
	@Gender BIT , 
	@PhoneNumber NVARCHAR(50) , 
	@Email NVARCHAR(50) ,
	@Address NVARCHAR(50)
AS
BEGIN
	
	INSERT INTO People(FirstName,SecondName,ThirdName,LastName,BirthDate,Gender,PhoneNumber,Email,Address)
	VALUES (@FirstName,@SecondName,@ThirdName,@LastName,@BirthDate,@Gender,@PhoneNumber,@Email,@Address);
	SELECT SCOPE_IDENTITY();


END 


----------------> 


CREATE PROCEDURE SP_DeletePersonByID
	@PersonID INT 
AS 
BEGIN 


	DELETE 
	FROM People 
	WHERE People.PersonID = @PersonID;


END 
