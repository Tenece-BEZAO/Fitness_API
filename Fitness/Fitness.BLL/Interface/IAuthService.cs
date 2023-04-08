using Fitness.BLL.DTO;

namespace Fitness.BLL.Interface
{
    public interface IAuthService
    {
        public Task<Response<FitFamerForAuthDTO>> LogInAsync(string email, string password);
    }
}
