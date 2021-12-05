CREATE OR ALTER PROCEDURE usp_UpdateProducerDetails
(
   	@producerId						NUMERIC(18,0)	=	NULL
   ,@producerName					NVARCHAR(20)	=	NULL
   ,@producerBDate					DATETIME		=	NULL
   ,@producerGender					NVARCHAR(10)	=	NULL
   ,@productionHouseName			NVARCHAR(10)	=	NULL
)
/*EXEC usp_UpdateProducerDetails
 @producerId=1	
,@producerName='Shah Rukh Khan'	
,@producerBDate='1958-05-01'	
,@producerGender='Male';
*/
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		DECLARE
			@errorCode		NVARCHAR(5)	=	NULL

		BEGIN TRANSACTION

			/*Main query start from here*/

			UPDATE MoviesDatabase.dbo.Producers
			SET
				ProduceName		= @producerName
			   ,BirthDate	= @producerBDate
			   ,Gender		= @producerGender
			   ,ProductionHouseName = @productionHouseName
			WHERE
				ProducerId		= @producerId;
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