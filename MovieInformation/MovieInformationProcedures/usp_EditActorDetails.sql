CREATE OR ALTER PROCEDURE usp_UpdateActorDetails
(
   	@actorId			NUMERIC(18,0)	=	NULL
   ,@actorName			NVARCHAR(20)	=	NULL
   ,@actorBDate			DATETIME		=	NULL
   ,@actorGender		NVARCHAR(10)	=	NULL
)
/*EXEC usp_UpdateActorDetails
 @actorId=2	
,@actorName='Shah Rukh Khan'	
,@actorBDate='1958-05-01'	
,@actorGender='Male';
*/
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		DECLARE
			@errorCode		NVARCHAR(5)	=	NULL

		BEGIN TRANSACTION

			/*Main query start from here*/

			UPDATE MoviesDatabase.dbo.Actors
			SET
				Name		= @actorName
			   ,BirthDate	= @actorBDate
			   ,Gender		= @actorGender
			WHERE
				ActorId		= @actorId;
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