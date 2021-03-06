USE [master]
GO
/****** Object:  Database [MoviesDatabase]    Script Date: 05-12-2021 18:09:44 ******/
CREATE DATABASE [MoviesDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MoviesDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MoviesDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MoviesDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MoviesDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MoviesDatabase] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MoviesDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MoviesDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MoviesDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MoviesDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MoviesDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MoviesDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [MoviesDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MoviesDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MoviesDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MoviesDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MoviesDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MoviesDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MoviesDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MoviesDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MoviesDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MoviesDatabase] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MoviesDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MoviesDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MoviesDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MoviesDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MoviesDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MoviesDatabase] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [MoviesDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MoviesDatabase] SET RECOVERY FULL 
GO
ALTER DATABASE [MoviesDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [MoviesDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MoviesDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MoviesDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MoviesDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MoviesDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MoviesDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MoviesDatabase', N'ON'
GO
ALTER DATABASE [MoviesDatabase] SET QUERY_STORE = OFF
GO
USE [MoviesDatabase]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Actors]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actors](
	[ActorId] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[BirthDate] [datetime2](7) NOT NULL,
	[Gender] [nvarchar](max) NULL,
 CONSTRAINT [PK_Actors] PRIMARY KEY CLUSTERED 
(
	[ActorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActorsMovies]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActorsMovies](
	[ActorsListActorId] [bigint] NOT NULL,
	[MoviesListMovieId] [bigint] NOT NULL,
 CONSTRAINT [PK_ActorsMovies] PRIMARY KEY CLUSTERED 
(
	[ActorsListActorId] ASC,
	[MoviesListMovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieId] [bigint] IDENTITY(1,1) NOT NULL,
	[MovieName] [nvarchar](max) NULL,
	[Plot] [nvarchar](max) NULL,
	[ReleaseDate] [datetime2](7) NULL,
	[ProducerName] [nvarchar](max) NULL,
	[ActorId] [bigint] NULL,
	[ActorIds] [nvarchar](max) NULL,
	[ProducerId1] [bigint] NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producers]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producers](
	[ProducerId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProduceName] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[BirthDate] [datetime2](7) NOT NULL,
	[Gender] [nvarchar](max) NULL,
	[ProductionHouseName] [nvarchar](max) NULL,
	[MovieId1] [bigint] NULL,
 CONSTRAINT [PK_Producers] PRIMARY KEY CLUSTERED 
(
	[ProducerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211205034135_movie', N'5.0.5')
GO
SET IDENTITY_INSERT [dbo].[Actors] ON 

INSERT [dbo].[Actors] ([ActorId], [Name], [BirthDate], [Gender]) VALUES (1, N'Akshay Kumar', CAST(N'1984-02-01T00:00:00.0000000' AS DateTime2), N'Male')
INSERT [dbo].[Actors] ([ActorId], [Name], [BirthDate], [Gender]) VALUES (2, N'Shah Rukh Khan', CAST(N'1958-05-01T00:00:00.0000000' AS DateTime2), N'Male')
SET IDENTITY_INSERT [dbo].[Actors] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([MovieId], [MovieName], [Plot], [ReleaseDate], [ProducerName], [ActorId], [ActorIds], [ProducerId1]) VALUES (5, N'Bahubali', N'bAHUBALI', CAST(N'2017-08-19T00:00:00.0000000' AS DateTime2), N'Sajidnadiawala', 1, N'', 2)
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
SET IDENTITY_INSERT [dbo].[Producers] ON 

INSERT [dbo].[Producers] ([ProducerId], [ProduceName], [Name], [BirthDate], [Gender], [ProductionHouseName], [MovieId1]) VALUES (2, N'Shah Rukh Khan', N'Salman Khan', CAST(N'1958-05-01T00:00:00.0000000' AS DateTime2), N'Male', NULL, NULL)
INSERT [dbo].[Producers] ([ProducerId], [ProduceName], [Name], [BirthDate], [Gender], [ProductionHouseName], [MovieId1]) VALUES (3, NULL, N'Salman Khan', CAST(N'1950-06-01T00:00:00.0000000' AS DateTime2), N'Male', NULL, NULL)
INSERT [dbo].[Producers] ([ProducerId], [ProduceName], [Name], [BirthDate], [Gender], [ProductionHouseName], [MovieId1]) VALUES (6, N'SajidNadiaWala', NULL, CAST(N'1947-08-09T00:00:00.0000000' AS DateTime2), N'Male', N'Karma Production', NULL)
SET IDENTITY_INSERT [dbo].[Producers] OFF
GO
/****** Object:  Index [IX_ActorsMovies_MoviesListMovieId]    Script Date: 05-12-2021 18:09:45 ******/
CREATE NONCLUSTERED INDEX [IX_ActorsMovies_MoviesListMovieId] ON [dbo].[ActorsMovies]
(
	[MoviesListMovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Movies_ProducerId1]    Script Date: 05-12-2021 18:09:45 ******/
CREATE NONCLUSTERED INDEX [IX_Movies_ProducerId1] ON [dbo].[Movies]
(
	[ProducerId1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Producers_MovieId1]    Script Date: 05-12-2021 18:09:45 ******/
CREATE NONCLUSTERED INDEX [IX_Producers_MovieId1] ON [dbo].[Producers]
(
	[MovieId1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ActorsMovies]  WITH CHECK ADD  CONSTRAINT [FK_ActorsMovies_Actors_ActorsListActorId] FOREIGN KEY([ActorsListActorId])
REFERENCES [dbo].[Actors] ([ActorId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ActorsMovies] CHECK CONSTRAINT [FK_ActorsMovies_Actors_ActorsListActorId]
GO
ALTER TABLE [dbo].[ActorsMovies]  WITH CHECK ADD  CONSTRAINT [FK_ActorsMovies_Movies_MoviesListMovieId] FOREIGN KEY([MoviesListMovieId])
REFERENCES [dbo].[Movies] ([MovieId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ActorsMovies] CHECK CONSTRAINT [FK_ActorsMovies_Movies_MoviesListMovieId]
GO
ALTER TABLE [dbo].[Movies]  WITH CHECK ADD  CONSTRAINT [FK_Movies_Producers_ProducerId1] FOREIGN KEY([ProducerId1])
REFERENCES [dbo].[Producers] ([ProducerId])
GO
ALTER TABLE [dbo].[Movies] CHECK CONSTRAINT [FK_Movies_Producers_ProducerId1]
GO
ALTER TABLE [dbo].[Producers]  WITH CHECK ADD  CONSTRAINT [FK_Producers_Movies_MovieId1] FOREIGN KEY([MovieId1])
REFERENCES [dbo].[Movies] ([MovieId])
GO
ALTER TABLE [dbo].[Producers] CHECK CONSTRAINT [FK_Producers_Movies_MovieId1]
GO
/****** Object:  StoredProcedure [dbo].[usp_AddActorDetails]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[usp_AddActorDetails]
(
	 @name					nvarchar(20)	= null
	,@birthDate				datetime		= null
	,@gender				nvarchar(20)	= null
)
/*EXEC usp_AddActorDetails
	 @name		= 'Salman khan'
	,@birthDate	= '1950-06-01'
	,@gender	= 'Male'
*/
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		DECLARE
			@errorCode				VARCHAR(5)		= NULL
		   ,@codeId					NUMERIC(18)		= NULL			

		BEGIN TRANSACTION
			/*transaction begin*/
			INSERT INTO MoviesDatabase.dbo.Actors
			(
				Name
			   ,BirthDate
			   ,Gender
			)
			VALUES
			(
				@name
			   ,@birthDate
			   ,@gender
			)

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
GO
/****** Object:  StoredProcedure [dbo].[usp_AddMovieDetails]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[usp_AddMovieDetails]
(
	 @name				nvarchar(20)	= null
	,@releaseDate		datetime		= null
	,@plot				nvarchar(20)	= null
	,@actorIds          nvarchar(20)	= null
	,@producerId		numeric(20)		= null
)
/*EXEC usp_AddActorDetails
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
GO
/****** Object:  StoredProcedure [dbo].[usp_AddProducerDetails]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[usp_AddProducerDetails]
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
				Name
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
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteActorDetails]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[usp_DeleteActorDetails]
(
	@actorId		NUMERIC(18)
)
/*
exec usp_DeleteActorDetails
@actorId = 2
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
				MoviesDatabase.dbo.Actors
			WHERE
				ActorId = @actorId;
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
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteMovieDetails]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[usp_DeleteMovieDetails]
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
GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteProducerDetails]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[usp_DeleteProducerDetails]
(
	@producerId		NUMERIC(18)
)
/*
exec usp_DeleteActorDetails
@producerId = 
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
				MoviesDatabase.dbo.Producers
			WHERE
				ProducerId = @producerId;
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
GO
/****** Object:  StoredProcedure [dbo].[usp_GetActorDetails]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[usp_GetActorDetails]
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
GO
/****** Object:  StoredProcedure [dbo].[usp_GetMovieDetails]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[usp_GetMovieDetails]
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
GO
/****** Object:  StoredProcedure [dbo].[usp_GetProducersDetails]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[usp_GetProducersDetails]
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
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateActorDetails]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[usp_UpdateActorDetails]
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
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateMoviesDetails]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[usp_UpdateMoviesDetails]
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
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateProducerDetails]    Script Date: 05-12-2021 18:09:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[usp_UpdateProducerDetails]
(
   	@producerId						NUMERIC(18,0)	=	NULL
   ,@producerName					NVARCHAR(20)	=	NULL
   ,@producerBDate					DATETIME		=	NULL
   ,@producerGender					NVARCHAR(10)	=	NULL
   ,@productionHouseName			NVARCHAR(10)	=	NULL
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
GO
USE [master]
GO
ALTER DATABASE [MoviesDatabase] SET  READ_WRITE 
GO
