using System;
using AutoMapper;
using Fitness.BLL.DTO;
using Fitness.BLL.Interface;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace Fitness.BLL.Implementation
{
    public class ExerciseService : IExerciseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Exercise> _exercise;
        private readonly IMapper _mapper;

        public ExerciseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _exercise = _unitOfWork.GetRepository<Exercise>();


        }
        public async Task CreateExercise(Exercise exercise)
        {
            bool exerciseExists = await _exercise.AnyAsync(c =>
                c.Name.ToLower() == exercise.Name.ToLower());

            if (exerciseExists)
                throw new InvalidOperationException("Item already exists");

            Exercise newExercise = _mapper.Map<Exercise>(exercise);


            await _exercise.AddAsync(newExercise);


        }

        public async Task DeleteExercise(int exerciseId)
        {
            var exercise = await _exercise.GetSingleByAsync(e => e.Id == exerciseId);
            if (exercise == null)
            {
                throw new InvalidOperationException("Exercise does not exist");
            }
            await _exercise.DeleteAsync(exercise);
        }



        public async Task<Exercise?> GetExercise(int exerciseId)
        {
            var exercise = await _exercise.GetSingleByAsync(x => x.Id == exerciseId);
            if (exercise == null)
            {
                throw new InvalidOperationException("no Exercise with that Id");
            }
            return exercise;
        }

        public async Task<IEnumerable<Exercise>> GetExercises()
        {
            IEnumerable<Exercise> exercises = await _exercise.GetAllAsync();

            if (!exercises.Any())
                throw new InvalidOperationException("Exercise is empty");
            return exercises;
        }

        public async Task UpdateExercise(int exerciseId, JsonPatchDocument<ExerciseForUpdateDto> jsonPatchDocument)
        {
            Exercise exercise = await GetExercise(exerciseId);

            if (exercise == null)
                throw new InvalidOperationException("No item found");

            ExerciseForUpdateDto DataToUpdate = _mapper.Map<ExerciseForUpdateDto>(exercise);

            jsonPatchDocument.ApplyTo(DataToUpdate);

            Exercise UpdatedExercise = _mapper.Map(DataToUpdate, exercise);

            await _exercise.UpdateAsync(UpdatedExercise);
        }


    }
}

