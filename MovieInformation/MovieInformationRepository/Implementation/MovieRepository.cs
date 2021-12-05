using Dapper;
using MovieInformationRepository.DapperHelper;
using MovieInformationRepository.Interfaces;
using MovieInformationRepository.Parameters;
using MovieInformationRepository.RecordModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace MovieInformationRepository.Implementation
{
    public class MovieRepository : IMovieRepository
    {
        /// <summary>
        /// Instance of IDb Helper
        /// </summary>
        private readonly IDbHelper _dbHelper;

        #region ProcedureNames
        /// <summary>
        /// Procedure Add Actor Details
        /// </summary>
        private const string ProcedureAddActorDetails = "usp_AddActorDetails";

        /// <summary>
        /// Delete the actor details
        /// </summary>
        private const string ProcedureDeleteActorDetails = "usp_DeleteActorDetails";

        /// <summary>
        /// Procedure Get Actor Details
        /// </summary>
        private const string ProcedureGetActorDetails = "usp_GetActorDetails";

        /// <summary>
        /// Procedure Update Actor Details
        /// </summary>
        private const string ProcedureUpdateActorDetails = "usp_UpdateActorDetails";

        /// <summary>
        /// Procedure Add Producer Details
        /// </summary>
        private const string ProcedureAddProducerDetails = "usp_AddProducerDetails";

        /// <summary>
        /// Delete the Producer details
        /// </summary>
        private const string ProcedureDeleteProducerDetails = "usp_DeleteProducerDetails";

        /// <summary>
        /// Procedure Get Producer Details
        /// </summary>
        private const string ProcedureGetProducerDetails = "usp_GetProducersDetails";

        /// <summary>
        /// Procedure Update Producer Details
        /// </summary>
        private const string ProcedureUpdateProducerDetails = "usp_UpdateProducerDetails";

        /// <summary>
        /// Procedure Add Movie Details
        /// </summary>
        private const string ProcedureAddMovieDetails = "usp_AddMovieDetails";

        /// <summary>
        /// Delete the Movie details
        /// </summary>
        private const string ProcedureDeleteMovieDetails = "usp_DeleteMovieDetails";

        /// <summary>
        /// Procedure Get Movie Details
        /// </summary>
        private const string ProcedureGetMovieDetails = "usp_GetMovieDetails";

        /// <summary>
        /// Procedure Update Movie Details
        /// </summary>
        private const string ProcedureUpdateMovieDetails = "usp_UpdateMoviesDetails";
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dbHelper"></param>
        public MovieRepository(IDbHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        #region Actor
        /// <summary>
        /// Add details of Actor
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<int> AddActorDetailsAsync(ActorsDetailParameters parameters)
        {
            var dpParams = new DynamicParameters();
            dpParams.Add("@name", parameters.Name);
            dpParams.Add("@birthDate", parameters.BirthDate);
            dpParams.Add("@gender", parameters.Gender);
            return await Task.FromResult(_dbHelper.Insert<int>(ProcedureAddActorDetails, dpParams, commandType: CommandType.StoredProcedure));
        }

        /// <summary>
        /// Delete the details of actor
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<int> DeleteActorDetailsAsync(int Id)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("Id", Id);
            return await Task.FromResult(_dbHelper.Execute(ProcedureDeleteActorDetails, dbparams, commandType: CommandType.StoredProcedure));
        }

        /// <summary>
        /// Get actor details by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Actors> GetActorDetailsByIdAsync(int Id)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("Id", Id, DbType.Int32);
            return await Task.FromResult(_dbHelper.Get<Actors>(ProcedureGetActorDetails, dbparams, commandType: CommandType.StoredProcedure));
        }

        /// <summary>
        /// Update the details of actor
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<int> UpdateActorDetailsAsync(ActorsDetailParameters parameters)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("@actorId", parameters.ActorId);
            dbparams.Add("@actorName", parameters.Name);
            dbparams.Add("@actorBDate", parameters.BirthDate);
            dbparams.Add("@actorGender", parameters.Gender);
            return await Task.FromResult(_dbHelper.Update<int>(ProcedureUpdateActorDetails,dbparams, CommandType.StoredProcedure));
        }
        #endregion

        #region Producers
        /// <summary>
        /// Add details of Actor
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<int> AddProducersDetailsAsync(ProducerDetailParameters parameters)
        {
            var dpParams = new DynamicParameters();
            dpParams.Add("@name", parameters.Name);
            dpParams.Add("@birthDate", parameters.BirthDate);
            dpParams.Add("@gender", parameters.Gender);
            dpParams.Add("@productionHouse", parameters.ProductionHouse);
            return await Task.FromResult(_dbHelper.Insert<int>(ProcedureAddProducerDetails, dpParams, commandType: CommandType.StoredProcedure));
        }

        /// <summary>
        /// Delete the details of actor
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<int> DeleteProducersDetailsAsync(int Id)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("Id", Id);
            return await Task.FromResult(_dbHelper.Execute(ProcedureDeleteProducerDetails, dbparams, commandType: CommandType.StoredProcedure));
        }

        /// <summary>
        /// Get actor details by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Producers> GetProducersDetailsByIdAsync(int Id)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("Id", Id, DbType.Int32);
            return await Task.FromResult(_dbHelper.Get<Producers>(ProcedureGetProducerDetails, dbparams, commandType: CommandType.StoredProcedure));
        }

        /// <summary>
        /// Update the details of actor
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<int> UpdateProducersDetailsAsync(ProducerDetailParameters parameters)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("@producerId", parameters.ProducerId);
            dbparams.Add("@producerName", parameters.Name);
            dbparams.Add("@producerBDate", parameters.BirthDate);
            dbparams.Add("@producerGender", parameters.Gender);
            dbparams.Add("@productionHouseName", parameters.ProductionHouse);
            return await Task.FromResult(_dbHelper.Update<int>(ProcedureUpdateProducerDetails, dbparams, CommandType.StoredProcedure));
        }
        #endregion

        #region Movies
        /// <summary>
        /// Add the details of movies
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<int> AddMovieDetailsAsync(MovieDetailParameters parameters)
        {
            var dpParams = new DynamicParameters();
            dpParams.Add("@name", parameters.MovieName);
            dpParams.Add("@releaseDate", parameters.ReleaseDate);
            dpParams.Add("@plot", parameters.Plot);
            dpParams.Add("@actorIds", parameters.ActorIds);
            dpParams.Add("@producerId", parameters.ProducerId);
            return await Task.FromResult(_dbHelper.Insert<int>(ProcedureAddMovieDetails, dpParams, commandType: CommandType.StoredProcedure));
        }

        /// <summary>
        /// Delete a details of movies
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<int> DeleteMovieDetailsAsync(int Id)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("Id", Id);
            return await Task.FromResult(_dbHelper.Execute(ProcedureDeleteMovieDetails, dbparams, commandType: CommandType.StoredProcedure));
        }

        /// <summary>
        /// Get details of movies by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Movies> GetMovieDetailsByIdAsync(int Id)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("Id", Id, DbType.Int32);
            return await Task.FromResult(_dbHelper.Get<Movies>(ProcedureGetMovieDetails, dbparams, commandType: CommandType.StoredProcedure));
        }

        /// <summary>
        /// update the details of movies
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<int> UpdateMovieDetailsAsync(MovieDetailParameters parameters)
        {
            var dbparams = new DynamicParameters();
            dbparams.Add("@movieId", parameters.MovieId);
            dbparams.Add("@movieName", parameters.MovieName);
            dbparams.Add("@movieReleaseDate", parameters.ReleaseDate);
            dbparams.Add("@moviePlot", parameters.Plot);
            dbparams.Add("@movieProducer", parameters.Producer);
            return await Task.FromResult(_dbHelper.Update<int>(ProcedureUpdateMovieDetails, dbparams, CommandType.StoredProcedure));
        }
        #endregion
    }
}
