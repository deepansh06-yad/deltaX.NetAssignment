using Microsoft.Extensions.DependencyInjection;
using MovieInformationService.Implementation;
using MovieInformationService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieInformationService
{
    public static class DIHelper
    {
        public static void ConfigureService(ref IServiceCollection services)
        {
            MovieInformationRepository.IOCConfig.ConfigureService(ref services);
            services.AddScoped<IMovieService, MovieService>();
        }
    }
}
