CREATE OR ALTER PROCEDURE usp_GetProducersDetails
(
	@producerId		NUMERIC(10)
)
/*EXEC usp_GetProducersDetails
@producerId=1
*/
AS
BEGIN
	/*Main select starts from here*/
	SELECT
		ProduceName,
		BirthDate,
		Gender,
		ProductionHouseName,
		Movies.MovieId AS MovieName
	FROM
		MoviesDatabase.dbo.Producers
		JOIN Movies ON Producers.MovieId1 = Movies.MovieId
	WHERE
		ProducerId = @producerId;
END