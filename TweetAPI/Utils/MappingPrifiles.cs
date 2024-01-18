using AutoMapper;
using Model;
using Model.ProfileMapper;

namespace TweetAPI.Utils
{
    public class MappingPrifiles : Profile
    {
        public MappingPrifiles()
        {
            CreateMap<TweetCreateProfile, Tweet>();
            CreateMap<TweetUpdateProfile, Tweet>();
        }
    }
}