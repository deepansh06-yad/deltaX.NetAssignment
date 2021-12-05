CREATE OR ALTER PROCEDURE usp_AddProducerDetails
(
	 @name					nvarchar(20)	= null
	,@birthDate				datetime		= null
	,@gender				nvarchar(20)	= null
	,@productionHouse		nvarchar(20)	= null
)
/*EXEC usp_AddProducerDetails
	 @name		= 'Salman Khan'
	,@birthDate	= '1950-06-01'
	,@gender	= 'Male'
*/
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		DECLARE
			@errorCode				VARCHAR(5)		= NULL		
		   ,@codeId					NUMERIC(18,0)	= NULL		
		BEGIN TRANSACTION
			/*transaction begin*/
			INSERT INTO MoviesDatabase.dbo.Producers
			(
				ProduceName
			   ,BirthDate
			   ,Gender
			   ,ProductionHouseName
			)
			VALUES
			(
				@name
			   ,@birthDate
			   ,@gender
			   ,@productionHouse
			)
			SELECT @codeId AS ID;
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT != 0
		BEGIN
			ROLLBACK TRANSACTION;
		END
		
			SET @errorCode = IIF(@errorCode IS NULL, '1002', @errorCode);
		THROW 640500, @errorCode, 1;
	END CATCH
END