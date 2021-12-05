CREATE OR ALTER PROCEDURE usp_AddMovieDetails
(
	 @name				nvarchar(20)	= null
	,@releaseDate		datetime		= null
	,@plot				nvarchar(20)	= null
	,@actorIds          nvarchar(20)	= null
	,@producerId		numeric(20)		= null
)
/*EXEC usp_AddMovieDetails
	 @name		= 'Salman Khan'
	,@releaseDate	= '1950-06-01'
	,@plot	= 'Male'
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
			INSERT INTO MoviesDatabase.dbo.Movies
			(
				MovieName
			   ,ReleaseDate
			   ,Plot
			   ,ActorIds
			   ,ProducerId1
			)
			VALUES
			(
				@name
			   ,@releaseDate
			   ,@plot
			   ,@actorIds
			   ,@producerId
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