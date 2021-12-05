DELTAX Movie Assignment

i)Here In this project I have used latest version of .ner core(.net 5).
ii)It contains 3 modules
        i)Movies
        ii)Actors
        iii)Producers
iii)This projects uses Dapper for faster connection to database.
iv)I have used MYSQL Server for database
v)Mapper is used for mapping
vi)I have created store procedures for performing query. All the store procedure are develop according the coding guidelines with error throwing if transaction failed.
vii)I have wrriten executing statement in all the store procedure for better understanding.
viii)This project is created using dependency Injection


APIs Path  (Actor):-

PUT API:-

api/v1/movie/actors
{
        actorId=2	
        actorName='Shah Rukh Khan'
        actorBDate='1958-05-01'	
        actorGender='Male';
}

POST API:-


api/v1/movie/actors
{	
        actorName='Shah Rukh Khan'
        actorBDate='1958-05-01'	
        actorGender='Male';
}

Get API:-


api/v1/movie/actor-details
{
        "Id":1
}

Delete API:

api/v1/movie/actor
{
        "Id":1
}

APIs Path for Producer:-

PUT API:-

api/v1/movie/producers
{
        producerId=1	
        producerName='Shah Rukh Khan'
        producerBDate='1958-05-01'	
        producerGender='Male';
}

POST API:-

api/v1/movie/producers
{	
        producerName='Shah Rukh Khan'
        producerBDate='1958-05-01'	
        producerGender='Male';
}

GET API:-

api/v1/movie/producer-details
{
        "Id":1
}

DELETE API:-

api/v1/movie/producer
{
        "Id":1
}

APIs Path for Movie:-

PUT API:-

api/v1/movie/movies
{
        movieId=1	
        movieName='Shah Rukh Khan'	
        movieReleaseDate='1958-05-01'
        moviePlot='Moon'
        movieProducer='Karan jOhar'
}

POST API:-

api/v1/movie/movies
{	
        movieName='Shah Rukh Khan'	
        movieReleaseDate='1958-05-01'
        moviePlot='Moon'
        movieProducer='Karan jOhar'
}

GET API:-

api/v1/movie/movie-details
{
        "Id":1
}

DELETE API:-

api/v1/movie/movie
{
        "Id":1
}
