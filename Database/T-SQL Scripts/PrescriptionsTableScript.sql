-----> Add New Prescription

CREATE PROCEDURE SP_AddNewPrescription

	@medicationName NVARCHAR(50),
	@dosage NVARCHAR(50),
	@frequency NVARCHAR(50),
	@startDate DATE, 
	@endDate DATE,
	@specialInstructions NVARCHAR(50)

AS
BEGIN 

		INSERT INTO Prescriptions(MedicationName,Dosage,Frequency,StartDate,EndDate,SpecialInstructions)
		VALUES(@medicationName,@dosage,@frequency,@startDate,@endDate,@specialInstructions);
		SELECT SCOPE_IDENTITY();

END 
