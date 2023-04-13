using System;
using AutoMapper;
using Fitness.BLL.DTO;
using Fitness.DAL.Entities;

namespace Fitness.BLL.MappingProfile
{
    public class WorkOutHistoryProfile : Profile
    {
        public WorkOutHistoryProfile()
        {
            CreateMap<WorkOutExercise, WorkOutHistoryDto>().ReverseMap();
            CreateMap<WorkOutExercise, WorkOutHistoryForUpdateDto>().ReverseMap();
        }
    }
}

