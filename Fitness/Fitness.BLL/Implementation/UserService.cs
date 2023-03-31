using Fitness.BLL.Interface;
using Fitness.DAL.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
