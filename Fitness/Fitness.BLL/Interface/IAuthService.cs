using Fitness.BLL.DTO;

namespace Fitness.BLL.Interface
{
    public interface IAuthService
    {

        public Task<Response<FitFamerForAuthDTO>> LogInAsync(string email, string password);

        public Task<Response<FitFamerForAuthDTO>> LogInAsync(FitFamerForAuthDTO authModel);
        public Task<Response<string>> LogOutAsync();
        public Task<string> CreateToken();


    }
}
