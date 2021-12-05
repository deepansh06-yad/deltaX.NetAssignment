CREATE OR ALTER PROCEDURE usp_UpdateMoviesDetails
(
   	@movieId						NUMERIC(18,0)	=	NULL
   ,@movieName						NVARCHAR(20)	=	NULL
   ,@movieReleaseDate				DATETIME		=	NULL
   ,@moviePlot						NVARCHAR(10)	=	NULL
   ,@movieProducer					NVARCHAR(10)	=	NULL
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

			UPDATE MoviesDatabase.dbo.Movies
			SET
				MovieName		= @movieName
			   ,Plot			= @moviePlot
			   ,ReleaseDate		= @movieReleaseDate
			   ,ProducerName	= @movieProducer
			WHERE
				MovieId			= @movieId;
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