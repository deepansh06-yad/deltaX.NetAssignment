CREATE OR ALTER PROCEDURE usp_GetMovieDetails
(
	@movieId		NUMERIC(10)
)
/*EXEC usp_GetProducersDetails
@movieId=1
*/
AS
BEGIN
	/*Main select starts from here*/
	SELECT
		MovieName,
		Plot,
		ReleaseDate,
		Actors.ActorId AS ActorName,
		ProducerId1 AS ProducerName
	FROM
		MoviesDatabase.dbo.Movies
		JOIN Actors ON Movies.ActorId = Actors.ActorId
		JOIN Producers ON Movies.ProducerId1 = Producers.ProducerId
	WHERE
		MovieId = @movieId;
END