using Microsoft.Extensions.DependencyInjection;
using MovieInformationRepository.DapperHelper;
using MovieInformationRepository.Implementation;
using MovieInformationRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieInformationRepository
{
    public static class IOCConfig
    {
        public static void ConfigureService(ref IServiceCollection services)
        {
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IDbHelper, DbHelper>();
        }
    }
}
