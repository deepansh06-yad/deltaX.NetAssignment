using AutoMapper;
using MovieInformationModels;
using MovieInformationRepository.Interfaces;
using MovieInformationRepository.Parameters;
using MovieInformationRepository.RecordModels;
using MovieInformationService.Interfaces;
using MovieInformationService.RequestParameters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieInformationService.Implementation
{
    public class MovieService : IMovieService
    {
        /// <summary>
        /// IActorRepository instance
        /// </summary>
        private readonly IMovieRepository _repository;

        /// <summary>
        /// IMapper instance
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="mapper"></param>
        public MovieService(IMovieRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #region Actor
        /// <summary>
        /// Add details of actor
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<int> AddActorDetailsAsync(ActorRequestParameters parameters)
        {
            int records = await _repository.AddActorDetailsAsync(_mapper.Map<ActorRequestParameters, ActorsDetailParameters>(parameters));
            return records;
        }

        /// <summary>
        /// Delete a details of actor
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<int> DeleteActorDetailsAsync(int Id)
        {
            return await _repository.DeleteActorDetailsAsync(Id);
        }

        /// <summary>
        /// Get actor details by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<ActorModel> GetActorDetailsByIdAsync(int Id)
        {
            var records = await _repository.GetActorDetailsByIdAsync(Id);
            return _mapper.Map<Actors, ActorModel>(records);
        }

        /// <summary>
        /// Update details of actors
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<int> UpdateActorDetailsAsync(ActorRequestParameters parameters)
        {
            int records = await _repository.UpdateActorDetailsAsync(_mapper.Map<ActorRequestParameters, ActorsDetailParameters>(parameters));
            return records;
        }
        #endregion

        #region Producers
        /// <summary>
        /// Add the details of producers
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<int> AddProducersDetailsAsync(ProducerRequestParameters parameters)
        {
            return await _repository.AddProducersDetailsAsync(_mapper.Map<ProducerRequestParameters, ProducerDetailParameters>(parameters));
        }

        /// <summary>
        /// Delete a details of producers
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<int> DeleteProducersDetailsAsync(int Id)
        {
            return await _repository.DeleteProducersDetailsAsync(Id);
        }

        /// <summary>
        /// Get details of producers by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<ProducerModel> GetProducersDetailsByIdAsync(int Id)
        {
            var records = await _repository.GetProducersDetailsByIdAsync(Id);
            return _mapper.Map<Producers, ProducerModel>(records);
        }

        /// <summary>
        /// update the details of producers
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<int> UpdateProducersDetailsAsync(ProducerRequestParameters parameters)
        {
            return await _repository.UpdateProducersDetailsAsync(_mapper.Map<ProducerRequestParameters, ProducerDetailParameters>(parameters));
        }
        #endregion

        #region Movies
        /// <summary>
        /// Get details of movies by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<MovieModel> GetMovieDetailsByIdAsync(int Id)
        {
            var records = await _repository.GetMovieDetailsByIdAsync(Id);
            return _mapper.Map<Movies, MovieModel>(records);
        }

        /// <summary>
        /// Add the details of movies
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<int> AddMovieDetailsAsync(MovieRequestParameters parameters)
        {
            return await _repository.AddMovieDetailsAsync(_mapper.Map<MovieRequestParameters, MovieDetailParameters>(parameters));
        }

        /// <summary>
        /// Delete a details of movies
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<int> DeleteMovieDetailsAsync(int Id)
        {
            return await _repository.DeleteMovieDetailsAsync(Id);
        }

        /// <summary>
        /// update the details of movies
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<int> UpdateMovieDetailsAsync(MovieRequestParameters parameters)
        {
            return await _repository.UpdateMovieDetailsAsync(_mapper.Map<MovieRequestParameters, MovieDetailParameters>(parameters));
        }
        #endregion
    }
}
