
using AutoMapper;
using Framework.BLS.Models.Sample;

namespace Framework.BLS.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //**CreateMap<TEntity, VEntity>();
            CreateMap<SampleModel, SampleModel>().ReverseMap();
           
        }

    }
}
