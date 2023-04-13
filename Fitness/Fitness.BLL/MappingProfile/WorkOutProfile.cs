using System;
using AutoMapper;
using Fitness.BLL.DTO;
using Fitness.DAL.Entities;

namespace Fitness.BLL.MappingProfile
{
    public class WorkOutProfile : Profile
    {
        public WorkOutProfile()
        {
            CreateMap<WorkOut, WorkOutDto>().ReverseMap();
            CreateMap<WorkOut, WorkOutForUpdateDto>().ReverseMap();
        }
    }
}

