using AutoMapper;

namespace MakeupTok.Model.MappingProfiles;

public class MakeupTokInternalProfile : Profile
{

    /// <summary>
    /// Rila internal AutoMapper configuration
    /// </summary>
    public MakeupTokInternalProfile()
    {

        CreateMap<Open.User, User>();
        CreateMap<Open.MakeupStep, MakeupStep>();
        CreateMap<MakeupStep, Open.MakeupStep>();
        CreateMap<Open.Makeup, Makeup>();
        CreateMap<Makeup, Open.Makeup>();

    }

}