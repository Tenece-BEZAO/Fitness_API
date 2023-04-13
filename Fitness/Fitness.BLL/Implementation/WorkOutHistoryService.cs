using System;
using AutoMapper;
using Fitness.BLL.DTO;
using Fitness.BLL.Interface;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace Fitness.BLL.Implementation
{
    public class WorkOutHistoryService : IWorkOutHistory
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<WorkOutExercise> _workOutHistory;
        private readonly IMapper _mapper;

        public WorkOutHistoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _workOutHistory = _unitOfWork.GetRepository<WorkOutExercise>();

        }

        public async Task CreateWorkOutHistory(WorkOutHistoryDto workOutHistoryDto)
        {
            

            WorkOutExercise newWorkOutExercise = _mapper.Map<WorkOutExercise>(workOutHistoryDto);


            await _workOutHistory.AddAsync(newWorkOutExercise);
        }

        public async Task DeleteWorkOutHistory(int workOutHistoryId)
        {
            var workOutHistory = _workOutHistory.GetByIdAsync(workOutHistoryId);
            if (workOutHistory == null)
            {
                throw new InvalidOperationException("workOut history does not exist");
            }
            await _workOutHistory.DeleteByIdAsync(workOutHistory);


        }
        

        public async Task<WorkOutExercise> GetOneWorkOutHistory(int Id)
        {
            var workOutHistory = await _workOutHistory.GetSingleByAsync(x => x.Id == Id);
            if (workOutHistory == null)
            {
                throw new InvalidOperationException("no workout history with that Id");
            }
            return workOutHistory;
        }

        //public Task<WorkOutExercise> GetUserWorkOutHistory(int fitFamerId)
        //{
        //    var workOutHistory = await _workOutHistory.GetByAsync(x => x. == , includeProperties: "Achievement");

        //    IEnumerable<UserAchievementDto> Achievement = _mapper.Map<IEnumerable<UserAchievementDto>>(achievements);
        //    return Achievement;
        //}

        public async Task<IEnumerable<WorkOutExercise>> GetWorkOutHistory()
        {
            IEnumerable<WorkOutExercise> workOutHistoryList = await _workOutHistory.GetAllAsync();
            if (!workOutHistoryList.Any())
                throw new InvalidOperationException("WorkOut History is empty");
            return workOutHistoryList;

        }

        public async Task PatchWorkOutHistory(int Id, JsonPatchDocument<WorkOutHistoryForUpdateDto> jsonPatchDocument)
        {
            WorkOutExercise workOutExercise = await GetOneWorkOutHistory(Id);

            if (workOutExercise == null)
                throw new InvalidOperationException("No  WorkOut found");

            WorkOutHistoryForUpdateDto DataToUpdate = _mapper.Map<WorkOutHistoryForUpdateDto>(workOutExercise);

            jsonPatchDocument.ApplyTo(DataToUpdate);

            WorkOutExercise UpdatedWorkOutHistory = _mapper.Map(DataToUpdate, workOutExercise);

            await _workOutHistory.UpdateAsync(UpdatedWorkOutHistory);
        }
    }
}

