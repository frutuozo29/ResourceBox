using AutoMapper;

namespace ResourceBox.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(map =>
            {
                map.AddProfile<DomainToViewModelMappingProfile>();
                map.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}
