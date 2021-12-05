using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieInformationModels;
using MovieInformationService.Interfaces;
using MovieInformationService.RequestParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieInformation.API.Controllers
{
    [Route("api/v1/movie")]
    [ApiController]
    [Authorize]
    public class MovieController : ControllerBase
    {
        /// <summary>
        /// IActorService instance
        /// </summary>
        private readonly IMovieService _movieService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="movieService"></param>
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        #region Actor
        /// <summary>
        /// Add the details of producer
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        [HttpPost("actors")]
        public async Task<ActionResult<int>> AddActorDetailsAsync([FromBody] ActorRequestParameters parameters)
        {
            return await _movieService.AddActorDetailsAsync(parameters);
        }

        /// <summary>
        /// update the details of producer
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        [HttpPut("actors")]
        public async Task<ActionResult<int>> UpdateActorDetailsAsync([FromBody] ActorRequestParameters parameters)
        {
            return await _movieService.UpdateActorDetailsAsync(parameters);
        }

        /// <summary>
        /// Get details of producer by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("actor-details")]
        public async Task<ActionResult<ActorModel>> GetActorDetailsByIdAsync(int Id)
        {
            return await _movieService.GetActorDetailsByIdAsync(Id);
        }

        /// <summary>
        /// Delete a details of producer
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete("actor")]
        public async Task<ActionResult<int>> DeleteActorDetailsAsync(int Id)
        {
            return await _movieService.DeleteActorDetailsAsync(Id);
        }
        #endregion

        #region Producer
        /// <summary>
        /// Add the details of actor
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        [HttpPost("producers")]
        public async Task<ActionResult<int>> AddProducersDetailsAsync([FromBody] ProducerRequestParameters parameters)
        {
            return await _movieService.AddProducersDetailsAsync(parameters);
        }

        /// <summary>
        /// update the details of actors
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        [HttpPut("producers")]
        public async Task<ActionResult<int>> UpdateProducersDetailsAsync([FromBody] ProducerRequestParameters parameters)
        {
            return await _movieService.UpdateProducersDetailsAsync(parameters);
        }

        /// <summary>
        /// Get details of actor by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("producer-details")]
        public async Task<ActionResult<ProducerModel>> GetProducersDetailsByIdAsync(int Id)
        {
            return await _movieService.GetProducersDetailsByIdAsync(Id);
        }

        /// <summary>
        /// Delete a details of actors
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete("producer")]
        public async Task<ActionResult<int>> DeleteProducersDetailsAsync(int Id)
        {
            return await _movieService.DeleteProducersDetailsAsync(Id);
        }
        #endregion

        #region Movies
        /// <summary>
        /// Add the details of movies
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<int>> AddMovieDetailsAsync([FromBody] MovieRequestParameters parameters)
        {
            return await _movieService.AddMovieDetailsAsync(parameters);
        }

        /// <summary>
        /// update the details of movies
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult<int>> UpdateMovieDetailsAsync([FromBody] MovieRequestParameters parameters)
        {
            return await _movieService.UpdateMovieDetailsAsync(parameters);
        }

        /// <summary>
        /// Get details of movies by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<MovieModel>> GetMovieDetailsByIdAsync(int Id)
        {
            return await _movieService.GetMovieDetailsByIdAsync(Id);
        }

        /// <summary>
        /// Delete a details of movies
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<ActionResult<int>> DeleteMovieDetailsAsync(int Id)
        {
            return await _movieService.DeleteMovieDetailsAsync(Id);
        }
        #endregion
    }
}
