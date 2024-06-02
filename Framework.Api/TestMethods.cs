using ArgaamPlus.BLS.Services.MacroEconomics;
using ArgaamPlus.DAL.Entities;
using Common.BLS.Services.FiscalPeriods;
using Common.DAL.Entities;
using Consul;
using Framework.BLS.Services.Sample;
using Framework.DAL.Entities;
using System;
using System.Net;
using System.Reflection;
using static System.Net.WebRequestMethods;

namespace Pleromi.Api
{
    public static class TestMethods
    {
        public static IApplicationBuilder UseTestMethods(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            scope.ServiceProvider.GetRequiredService<Sampledb_Context>();
            var _sampleService = scope.ServiceProvider.GetRequiredService<ISampleService>();
            var abc = _sampleService.GetJsonDataFromCore().Result;

            return app;
        }
    }
}
