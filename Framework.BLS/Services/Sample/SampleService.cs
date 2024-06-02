using ArgaamPlus.Shared;
using Microsoft.EntityFrameworkCore;
using Framework.BLS.Helper;
using Framework.DAL.Entities;
using Framework.DAL.Petapoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.BLS.Services.Sample
{
    public class SampleService : ISampleService
    {
        private PetapocoServices _db;
        private readonly Sampledb_Context _context;

        public SampleService(Sampledb_Context context, PetapocoServices db)
        {
            _context = context;
            _db = db;
        }

        public async Task<dynamic> GetJsonDataFromCore()
        {
            
                var data = await _context.Samples.ToListAsync();
                return data;
           
        }

        public async Task<dynamic> GetJsonDataFromPetaPoco()
        {
            using (var context = _db.GetInstance())
            {
                var ppSql = PetoPocoSql.Builder.Select(@"*").From("Currencies");
                var result = await context.FetchAsync<TableModels.Currency>(ppSql);

                return result;
            }
        }
    }
}
