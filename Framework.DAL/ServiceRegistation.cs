﻿using ArgaamPlus.DAL.Entities;
using Framework.DAL.Petapoco;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Framework.DAL.Entities;
namespace Framework.DAL
{
    public static class ServiceRegistation
    {
        public static void AddPleromiDal(this IServiceCollection services, IConfiguration Configuration)
        {
            //Add Ef Core Db Context
            services.AddDbContext<Sampledb_Context>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SampleConnection")));
            //Add Petapoco Service
            services.AddTransient<PetapocoServices>();
        }
    }
}
