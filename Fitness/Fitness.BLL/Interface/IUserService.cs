using Fitness.BLL.DTO;

namespace Fitness.BLL.Interface
{
    public interface IUserService
    {
        public Task<Response<FitFamerForRegistrationDTO>> SignUpAsync(FitFamerForRegistrationDTO fitfamer);
        public Task<string> DeleteAUserAsync(int id);
        public Task<Response<FitFamerForRegistrationDTO>> GetAUserAsync(string id);
    }
}
