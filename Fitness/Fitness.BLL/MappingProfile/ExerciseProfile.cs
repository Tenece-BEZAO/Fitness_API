using System;
using AutoMapper;
using Fitness.DAL.Entities;
using Fitness.BLL.DTO;

namespace Fitness.BLL.MappingProfile
{
    public class ExerciseProfile : Profile
    {
        public ExerciseProfile()
        {


            CreateMap<Exercise, ExercisesDto>();
            CreateMap<ExercisesDto, Exercise>();
            CreateMap<ExerciseForUpdateDto, Exercise>().ReverseMap();


        }
    }
}

