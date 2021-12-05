CREATE OR ALTER PROCEDURE usp_GetActorDetails
(
	@actorId   numeric(18,0)
)
/*
EXEC usp_GetActorDetails
@actorId = 1;
*/
AS
BEGIN
	/*Main select starts from here*/
	SELECT
		Name,
		BirthDate,
		Gender
	FROM
		MoviesDatabase.dbo.Actors
	WHERE
		ActorId = @actorId;
END