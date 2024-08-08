
CREATE PROCEDURE SP_DoesUserExistByUsername
	
	@Username NVARCHAR(50)

AS 
BEGIN


	SELECT IsFound = 1
	FROM Users 
	WHERE Users.Username = @Username;


END



-------------->



CREATE PROCEDURE SP_IsUserActiveByUsername
	@Username NVARCHAR(50)
AS
BEGIN


	SELECT IsFound = 1
	FROM Users
	WHERE Users.Username = @Username AND Users.IsActive = 1;



END 


-------------->


CREATE PROCEDURE SP_Login
	@Username NVARCHAR(50) ,
	@Password NVARCHAR(50)

AS
BEGIN

 SELECT *
 FROM Users
 WHERE Users.Username = @Username AND Users.Password = @Password;



END 


--------------->




CREATE PROCEDURE SP_GetAllUsers
AS 
BEGIN

	SELECT *
	FROM Users;
 
END



--------------->

CREATE PROCEDURE SP_AddNewUser
	
	@PersonID INT ,
	@Username NVARCHAR(50) , 
	@Password NVARCHAR(50) ,
	@IsActive BIT

AS 
BEGIN

	INSERT INTO Users(PersonID,Username,Password,IsActive)
	VALUES (@PersonID,@Username,@Password,@IsActive);


END 



---------------> 

CREATE PROCEDURE SP_DeleteUserByUsername
	@Username NVARCHAR(50)
AS
BEGIN


	DELETE
	FROM Users 
	WHERE Users.Username = @Username;

END


--------------->

CREATE PROCEDURE SP_FindUserByUsername
	@Username NVARCHAR(50)
AS
BEGIN

	SELECT *
	FROM Users
	WHERE Users.Username = @Username;

END 

 
