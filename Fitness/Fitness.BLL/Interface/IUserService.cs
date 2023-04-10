using Fitness.BLL.DTO;

namespace Fitness.BLL.Interface
{
    public interface IUserService
    {
        public Task<Response<FitFamerForRegistrationDTO>> SignUpAsync(FitFamerForRegistrationDTO fitfamer);
        public Task<Response<FitFamerForAuthDTO>> DeleteAUserAsync(FitFamerForAuthDTO fitfamer);
        public Task<Response<FitFamerForRegistrationDTO>> GetAUserAsync(string id);
        public Task<Response<FitFamerForUpdateDTO>> UpdateAUserAsync(FitFamerForUpdateDTO model);
    }
}
