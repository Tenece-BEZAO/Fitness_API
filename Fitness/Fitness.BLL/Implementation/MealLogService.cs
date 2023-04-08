using Fitness.BLL.DTO.Requests;
using Fitness.BLL.Interface;
using Fitness.DAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace Fitness.BLL.Implementation
{
    public class MealLogService : IMealLogService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceFactory _serviceFactory;
        private readonly IRepository<MealLog> _mealLogrepo;
        private readonly IRepository<FoodStuffWCalories> _foodStuff2Repo;
        private readonly UserManager<User> _userManager;
        public MealLogService(IServiceFactory serviceFactory, IUnitOfWork unitOfWork)
        {
            _serviceFactory = serviceFactory;
            _unitOfWork = unitOfWork;
            _userManager = serviceFactory.GetService<UserManager<User>>();
            _mealLogrepo = unitOfWork.GetRepository<MealLog>();
            _foodStuff2Repo = unitOfWork.GetRepository<FoodStuffWCalories>();
        }

        /* public async void GetMealPlan(Guid mealLogId)
         {
             var meals = await _foodStuff2Repo.GetByAsync(x => x.MealLogID == mealLogId);

             var result = meals.Select(x => new
             {
                 Name = x.FoodStuffName,
                 AmtConnsumed = x.AmtConsumed,
                 TotalClaories = x?.FoodStuff?.Calories * x?.AmtConsumed
             });

             var mealLog = await _meal.GetSingleByAsync(x => x.Id == mealLogId, include: x => x.Include(x => x.FoodStuffWCalories));

             var totalcalories = mealLog.FoodStuffWCalories.Sum(x => x.AmtConsumed * x.FoodStuff.Calories);
         }

         public async void GetMealPlan2(Guid firFamerId, DateTime day)
         {
             var meals = await _foodStuff2Repo.GetByAsync(x => x. == mealLogId);

             var result = meals.Select(x => new
             {
                 Name = x.FoodStuffName,
                 AmtConnsumed = x.AmtConsumed,
                 TotalClaories = x?.FoodStuff?.Calories * x?.AmtConsumed
             });

             var mealLog = await _meal.GetSingleByAsync(x => x.Id == firFamerId, include: x => x.Include(x => x.FoodStuffWCalories));
             mealLog.CreatedAt.Date = time.Date
             var totalcalories = mealLog.FoodStuffWCalories.Sum(x => x.AmtConsumed * x.FoodStuff.Calories);*/
        // }
        public async Task AddMealLog(MealLogRequest request)
        {
            MealLog mealLog = new()
            {
                Name = request.Name,
                MealTime = request.MealTime,
            };
            await _mealLogrepo.AddAsync(mealLog);
        }

        public Task DeleteMealLog(Guid mealLogId)
        {
            throw new NotImplementedException();
        }

        public Task GetMealLog(Guid mealLogId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MealLog>> GetMealLogByDate(Guid fitfamerId, DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMealLog(Guid mealLogId)
        {
            throw new NotImplementedException();
        }
    }
}
