using AutoMapper;
using MovieInformationModels;
using MovieInformationRepository.Parameters;
using MovieInformationRepository.RecordModels;
using MovieInformationService.RequestParameters;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieInformationService.Mapping
{
    public class MovieMapping : Profile
    {
        public MovieMapping()
        {
            CreateMap<Actors, ActorModel>()
                .ForMember(dst => dst.ActorId, opt => opt.MapFrom(src => src.ActorId))
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dst => dst.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dst => dst.BirthDate, opt => opt.MapFrom(src => src.BirthDate));

            CreateMap<Movies, MovieModel>()
                .ForMember(dst => dst.ActorId, opt => opt.MapFrom(src => src.ActorId))
                .ForMember(dst => dst.MovieName, opt => opt.MapFrom(src => src.MovieName))
                .ForMember(dst => dst.Plot, opt => opt.MapFrom(src => src.Plot))
                .ForMember(dst => dst.ReleaseDate, opt => opt.MapFrom(src => src.ReleaseDate))
                .ForMember(dst => dst.ProducerName, opt => opt.MapFrom(src => src.ProducerName))
                .ForMember(dst => dst.ActorIds, opt => opt.MapFrom(src => src.ActorIds));

            CreateMap<Producers, ProducerModel>()
                .ForMember(dst => dst.ProducerId, opt => opt.MapFrom(src => src.ProducerId))
                .ForMember(dst => dst.ProduceName, opt => opt.MapFrom(src => src.ProduceName))
                .ForMember(dst => dst.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dst => dst.BirthDate, opt => opt.MapFrom(src => src.BirthDate))
                .ForMember(dst => dst.ProductionHouseName, opt => opt.MapFrom(src => src.ProductionHouseName));

            CreateMap<ActorRequestParameters, ActorsDetailParameters>()
                .ForMember(dst => dst.ActorId, opt => opt.MapFrom(src => src.ActorId))
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dst => dst.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dst => dst.BirthDate, opt => opt.MapFrom(src => src.BirthDate));

            CreateMap<ProducerRequestParameters, ProducerDetailParameters>()
                .ForMember(dst => dst.ProducerId, opt => opt.MapFrom(src => src.ProducerId))
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dst => dst.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dst => dst.ProductionHouse, opt => opt.MapFrom(src => src.ProductionHouse))
                .ForMember(dst => dst.BirthDate, opt => opt.MapFrom(src => src.BirthDate));

            CreateMap<MovieRequestParameters, MovieDetailParameters>()
                .ForMember(dst => dst.ProducerId, opt => opt.MapFrom(src => src.ProducerId))
                .ForMember(dst => dst.MovieId, opt => opt.MapFrom(src => src.MovieId))
                .ForMember(dst => dst.MovieName, opt => opt.MapFrom(src => src.MovieName))
                .ForMember(dst => dst.ReleaseDate, opt => opt.MapFrom(src => src.ReleaseDate))
                .ForMember(dst => dst.Plot, opt => opt.MapFrom(src => src.Plot))
                .ForMember(dst => dst.Producer, opt => opt.MapFrom(src => src.Producer))
                .ForMember(dst => dst.ActorIds, opt => opt.MapFrom(src => src.ActorIds));
        }
    }
}
