using System;
using AutoMapper;
using Fitness.BLL.DTO;
using Fitness.BLL.Interface;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace Fitness.BLL.Implementation
{
    public class AchievementService : IAchievementService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Achievement> _achievement;
        private readonly IRepository<UserAchievement> _userAchievement;
        private readonly IMapper _mapper;

        public AchievementService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _achievement = _unitOfWork.GetRepository<Achievement>();
            _userAchievement = _unitOfWork.GetRepository<UserAchievement>();

        }



        public async Task<IEnumerable<Achievement>> GetAchievements()
        {
            IEnumerable<Achievement> achievementList = await _achievement.GetAllAsync();
            //var result = new List<AchievementsDto>();
            //foreach(var achievement in achievementEntity)
            //{
            //    result.Add(new AchievementsDto
            //    {

            //        Name = achievement.Name,
            //        Date = achievement.Date,
            //        Description = achievement.Description

            //    });
            //}
            if (!achievementList.Any())
                throw new InvalidOperationException("Achievement is empty");
            return achievementList;


        }

        public async Task<Achievement> GetAchievement(int Id)
        {
            var achievement = await _achievement.GetSingleByAsync(x => x.Id == Id);
            if (achievement == null)
            {
                throw new InvalidOperationException("no Achievement with that Id");
            }
            return achievement;

        }


        public async Task<IEnumerable<UserAchievementDto>> GetUserAchievementsAsync(Guid userId)
        {
            var achievements = await _userAchievement.GetByAsync(x => x.FitFamerId == userId, includeProperties: "Achievement");

            IEnumerable<UserAchievementDto> Achievement = _mapper.Map<IEnumerable<UserAchievementDto>>(achievements);
            return Achievement;
        }

        public async Task CreateAchievement(AchievementsDto achievementsDto)
        {
            bool achievementExists = await _achievement.AnyAsync(c =>
                c.Name.ToLower() == achievementsDto.Name.ToLower());

            if (achievementExists)
                throw new InvalidOperationException("Achievement already exists");

            Achievement newAchievement = _mapper.Map<Achievement>(achievementsDto);


            await _achievement.AddAsync(newAchievement);



        }


        public async Task UpdateAchievement(int achievementId, AchievementForUpdateDto achievementForUpdateDto)
        {




            Achievement achievement = await _achievement.GetSingleByAsync(c =>
                c.Id == achievementId);

            if (achievement == null)
                throw new InvalidOperationException("Achievement doesnt exist");

            Achievement newAchievement = _mapper.Map(achievementForUpdateDto, achievement);

            await _achievement.UpdateAsync(newAchievement);
        }

        public async Task DeleteAchievement(int achievementId)
        {
            var achievement = _achievement.GetByIdAsync(achievementId);
            if (achievement == null)
            {
                throw new InvalidOperationException("Achievement does not exist");
            }
            await _achievement.DeleteByIdAsync(achievementId);



        }

        public async Task PatchAchievement(int Id, JsonPatchDocument<AchievementForUpdateDto> jsonPatchDocument)
        {
            Achievement achievement = await GetAchievement(Id);

            if (achievement == null)
                throw new InvalidOperationException("No  achievement found");

            AchievementForUpdateDto DataToUpdate = _mapper.Map<AchievementForUpdateDto>(achievement);

            jsonPatchDocument.ApplyTo(DataToUpdate);

            Achievement UpdatedAchievement = _mapper.Map(DataToUpdate, achievement);

            await _achievement.UpdateAsync(UpdatedAchievement);
        }


    }
}

