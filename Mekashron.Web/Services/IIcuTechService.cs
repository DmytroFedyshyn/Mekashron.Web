using Mekashron.Web.Models;
using Mekashron.Web.Services.Dtos;

namespace Mekashron.Web.Services
{
    public interface IIcuTechService
    {
        Task<LoginResponseDto> LoginUser(LoginModel login);
    }
}
