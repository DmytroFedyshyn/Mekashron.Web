using IcuTech;
using Mekashron.Web.Models;
using Mekashron.Web.Services.Dtos;
using System.Text.Json;

namespace Mekashron.Web.Services
{
    public class IcuTechService : IIcuTechService
    {
        private readonly IICUTech _icuTechClient;

        public IcuTechService(IICUTech icuTechClient)
        {
            _icuTechClient = icuTechClient;
        }

        public async Task<LoginResponseDto> LoginUser(LoginModel login)
        {
            LoginResponse response = await _icuTechClient.LoginAsync(new LoginRequest()
            {
                Password = login.Password,
                UserName = login.UserName,
            });
            var result = response.@return;
            LoginResponseDto? loginResponseDto = JsonSerializer.Deserialize<LoginResponseDto>(result);
            return loginResponseDto;
        }
    }
}
