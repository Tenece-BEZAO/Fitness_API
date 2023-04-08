using Fitness.BLL.DTO.Requests;
using Fitness.BLL.Interface;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace Fitness.BLL.Implementation
{
    public class FoodStuffService : IFoodStuffService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceFactory _serviceFactory;
        private readonly IRepository<FoodStuff> _foodStuffRepo;


        private readonly UserManager<User> _userManager;

        public FoodStuffService(IServiceFactory serviceFactory, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _serviceFactory = serviceFactory;
            //_mapper = mapper;
            _userManager = serviceFactory.GetService<UserManager<User>>();
            _foodStuffRepo = _unitOfWork.GetRepository<FoodStuff>();
        }

        public async Task AddFoodStuff(FoodStuffRequest request)
        {

            FoodStuff foodStuff = new FoodStuff()
            {
               // Id = request.Id,
                Name = request.Name,
                FoodClass = request.FoodClass,
                Calories = request.Calories,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            await _foodStuffRepo.AddAsync(foodStuff);
        }

        public async Task DeleteFoodStuff(string name)
        {
            FoodStuff foodStuff = await _foodStuffRepo.GetSingleByAsync(f =>
            f.Name.ToLower() == name.ToLower());

            if (foodStuff == null)
                throw new InvalidOperationException("Food does not exist");


            await _foodStuffRepo.DeleteAsync(foodStuff);
        }


        public async Task UpdateFoodStuff(string name, FoodStuffRequest request)
        {
            FoodStuff foodStuff = await _foodStuffRepo.GetSingleByAsync(f =>
            f.Name.ToLower() == name.ToLower());

            if (foodStuff == null)
                throw new InvalidOperationException("Food does not exist");

            foodStuff.Name = request.Name;
            foodStuff.FoodClass = request.FoodClass;
            foodStuff.UpdatedAt = DateTime.Now;
            foodStuff.Calories = request.Calories;

            await _foodStuffRepo.UpdateAsync(foodStuff);
        }

        public async Task<IEnumerable<FoodStuff>> ViewFoodStuffs()
        {
            IEnumerable<FoodStuff> foodStuffs = await _foodStuffRepo.GetAllAsync();

            if (!foodStuffs.Any())
                throw new InvalidOperationException("Food stuff list is empty");

            return foodStuffs;

        }

    }
}
