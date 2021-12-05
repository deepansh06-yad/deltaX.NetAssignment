using MovieInformationModels;
using MovieInformationService.RequestParameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieInformationService.Interfaces
{
    public interface IMovieService
    {
        #region Actor
        /// <summary>
        /// Get details of actor by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<ActorModel> GetActorDetailsByIdAsync(int Id);

        /// <summary>
        /// Add the details of actor
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<int> AddActorDetailsAsync(ActorRequestParameters parameters);

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
        Task<int> UpdateActorDetailsAsync(ActorRequestParameters parameters);
        #endregion

        #region Producer
        /// <summary>
        /// Get details of producers by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<ProducerModel> GetProducersDetailsByIdAsync(int Id);

        /// <summary>
        /// Add the details of producers
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<int> AddProducersDetailsAsync(ProducerRequestParameters parameters);

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
        Task<int> UpdateProducersDetailsAsync(ProducerRequestParameters parameters);
        #endregion

        #region Movies
        /// <summary>
        /// Get details of movies by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<MovieModel> GetMovieDetailsByIdAsync(int Id);

        /// <summary>
        /// Add the details of movies
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<int> AddMovieDetailsAsync(MovieRequestParameters parameters);

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
        Task<int> UpdateMovieDetailsAsync(MovieRequestParameters parameters);
        #endregion
    }
}
