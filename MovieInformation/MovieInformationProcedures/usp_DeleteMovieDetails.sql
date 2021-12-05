CREATE OR ALTER PROCEDURE usp_DeleteMovieDetails
(
	@movieId		NUMERIC(18)
)
/*
exec usp_DeleteProducerDetails
@producerId = 1
*/
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		DECLARE
			@errorcode  NUMERIC(5) = NULL
		BEGIN TRANSACTION
			DELETE
			FROM
				MoviesDatabase.dbo.Movies
			WHERE
				MovieId = @movieId;
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