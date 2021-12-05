using MovieInformationRepository.Parameters;
using MovieInformationRepository.RecordModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieInformationRepository.Interfaces
{
    public interface IMovieRepository
    {
        #region ActorDetails
        /// <summary>
        /// Get details of actor by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<Actors> GetActorDetailsByIdAsync(int Id);

        /// <summary>
        /// Add the details of actor
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<int> AddActorDetailsAsync(ActorsDetailParameters parameters);

        /// <summary>
        /// Delete a details of actors
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<int> DeleteActorDetailsAsync(int Id);

        /// <summary>
        /// update the details of actors
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<int> UpdateActorDetailsAsync(ActorsDetailParameters parameters);
        #endregion

        #region Producers
        /// <summary>
        /// Get details of producers by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<Producers> GetProducersDetailsByIdAsync(int Id);

        /// <summary>
        /// Add the details of producers
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<int> AddProducersDetailsAsync(ProducerDetailParameters parameters);

        /// <summary>
        /// Delete a details of producers
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<int> DeleteProducersDetailsAsync(int Id);

        /// <summary>
        /// update the details of producers
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<int> UpdateProducersDetailsAsync(ProducerDetailParameters parameters);
        #endregion

        #region Movies
        /// <summary>
        /// Get details of movies by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<Movies> GetMovieDetailsByIdAsync(int Id);

        /// <summary>
        /// Add the details of movies
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<int> AddMovieDetailsAsync(MovieDetailParameters parameters);

        /// <summary>
        /// Delete a details of movies
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<int> DeleteMovieDetailsAsync(int Id);

        /// <summary>
        /// update the details of movies
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<int> UpdateMovieDetailsAsync(MovieDetailParameters parameters);
        #endregion
    }
}
