using System;
using AutoMapper;
using Fitness.DAL.Entities;
using Fitness.BLL.DTO;

namespace Fitness.BLL.MappingProfile
{
    public class AchievementProfile : Profile
    {
        public AchievementProfile()
        {
            CreateMap<Achievement, AchievementsDto>();
            CreateMap<AchievementsDto, Achievement>();
            CreateMap<AchievementForUpdateDto, Achievement>();
            CreateMap<Achievement, AchievementForUpdateDto>();
            CreateMap<UserAchievement, UserAchievementDto>()
                .ForMember(dest => dest.DateAchieved, opt => opt.MapFrom(src => src.CreatedAt)).ReverseMap();
        }
    }
}

