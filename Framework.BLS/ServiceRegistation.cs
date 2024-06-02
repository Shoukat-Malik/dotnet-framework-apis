using Framework.BLS.Helper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Common.BLS.Services.FiscalPeriods;
using ArgaamPlus.BLS.Services.MacroEconomics;
using Common.BLS.Services.Common;
using Common.BLS.Utils;
using ArgaamPlus.BLS.Services.MeasuringUnits;
using Framework.BLS.Services.Generic;
using Framework.BLS.Services.Sample;

namespace Framework.BLS
{
    public static class ServiceRegistation
    {
        public static void AddPleromiBLS(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddTransient<IGenericService, GenericService>();
            services.AddTransient<ISampleService, SampleService>();
        }
    }
}
