using Fitness.BLL.DTO.Requests;
using Fitness.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BLL.Interface
{
    public interface IFoodStuffService
    {
        Task AddFoodStuff(FoodStuffRequest request);
        public Task DeleteFoodStuff(string name);
        Task UpdateFoodStuff(string name, FoodStuffRequest request);
        Task<IEnumerable<FoodStuff>> ViewFoodStuffs();
    }
}
