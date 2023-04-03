using Fitness.BLL.Interface;
using Fitness.DAL.DBContext;

namespace Fitness.BLL.Implementation
{
    public class UserService : IUserService
    {
        private readonly FitnessDbContext _context;

        public UserService(FitnessDbContext context)
        {
            _context = context;
        }
        public void CreateAUser()
        {

        }
        public void UpdateAUser()
        {

        }
        public void DeleteAUser()
        {

        }
        public void GetAUser()
        {

        }
    }
}
