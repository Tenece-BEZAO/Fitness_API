using System;
using AutoMapper;
using Fitness.BLL.DTO;
using Fitness.BLL.Interface;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace Fitness.BLL.Implementation
{
    public class WorkOutService : IWorkOutService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<WorkOut> _workOut;
        private readonly IMapper _mapper;

        public WorkOutService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _workOut = _unitOfWork.GetRepository<WorkOut>();
           
        }

        public async Task CreateWorkout(WorkOutDto workOutDto)
        {
            bool workOutExists = await _workOut.AnyAsync(c =>
                c.WorkOutDate == workOutDto.WorkOutDate);

            if (workOutExists)
                throw new InvalidOperationException("This is an already registered workout");

            WorkOut newWorkOut = _mapper.Map<WorkOut>(workOutDto);


            await _workOut.AddAsync(newWorkOut);
        }

        public async Task DeleteWorkOut(int workOutId)
        {
            var workOut = _workOut.GetByIdAsync(workOutId);
            if (workOut == null)
            {
                throw new InvalidOperationException("Workout does not exist");
            }
            await _workOut.DeleteByIdAsync(workOutId);

        }

        public async Task<IEnumerable<WorkOut>> GetUserWorkOuts(Guid userId)
        {
            var workOut = await _workOut.GetByAsync(x => x.FitFamerId == userId);

            IEnumerable<WorkOut> WorkOut = _mapper.Map<IEnumerable<WorkOut>>(workOut);
            return WorkOut;
        }

        public async Task<WorkOut?> GetWorkOut(int workOutId)
        {
            var workOut = await _workOut.GetSingleByAsync(x => x.Id == workOutId);
            if (workOut == null)
            {
                throw new InvalidOperationException("no workout with that Id");
            }
            return workOut;
        }

        public async Task<IEnumerable<WorkOut>> GetWorkOuts()
        {
            IEnumerable<WorkOut> workOutList = await _workOut.GetAllAsync();
            if (!workOutList.Any())
                throw new InvalidOperationException("workout is empty");
            return workOutList.Select(w => new WorkOut
            {
                FitFamerId = w.FitFamerId,
                WorkOutDate = w.WorkOutDate,
                LiveWeight = w.LiveWeight,
                CreatedAt = w.CreatedAt
            });
        }

        public async Task UpdateWorkOut(int workOutId, JsonPatchDocument<WorkOutForUpdateDto> jsonPatchDocument)
        {
            WorkOut workOut = await GetWorkOut(workOutId);

            if (workOut == null)
                throw new InvalidOperationException("No  workout found");

            WorkOutForUpdateDto DataToUpdate = _mapper.Map<WorkOutForUpdateDto>(workOut);

            jsonPatchDocument.ApplyTo(DataToUpdate);

            WorkOut UpdatedWorkOut = _mapper.Map(DataToUpdate, workOut);

            await _workOut.UpdateAsync(UpdatedWorkOut);
        }



    }
}

