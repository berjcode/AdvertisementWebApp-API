using AdvertisementApp.Data.Abstract.UnitOfWork;
using AdvertisementApp.Data.Concrete.Entityframework.Contexts;
using AdvertisementApp.Data.Concrete.UnitOfWork;
using AdvertisementApp.Services.Abstract;
using AdvertisementApp.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementApp.Services.Extensions
{
   public static class ServiceCollectionExtensions
    {

        public static IServiceCollection LoadMyService(this IServiceCollection services)
        {
            services.AddDbContext<AdvertisementAppContext>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ICategoryService, CategoryManager>();

            return services;
        }
    }
}
