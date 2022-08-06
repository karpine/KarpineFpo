using AutoMapper;
using Karpine.Fpo.Crops;
using Karpine.Fpo.FarmerProfiles;

namespace Karpine.Fpo;

public class FpoApplicationAutoMapperProfile : Profile
{
    public FpoApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<FarmerProfile, FarmerProfileDto>();
        CreateMap<CreateUpdateFarmerProfileDto, FarmerProfile>();

        CreateMap<Crop, CropDto>();
        CreateMap<CreateUpdateCropDto, Crop>();
    }
}
