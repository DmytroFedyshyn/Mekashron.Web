using Mekashron.Web.Models;
using Mekashron.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Mekashron.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly IIcuTechService _icuTechService;

        public bool Result { get; set; }
        public bool IsPost { get; set; }
        public string Message { get; set; }

        public LoginModel Userlogin { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IIcuTechService icuTechService)
        {
            _logger = logger;
            _icuTechService = icuTechService;
        }

        public void OnGet()
        {
            //Result = false;
            //Userlogin = new LoginModel()
            //{
            //    UserName = "abc@test.com",
            //    Password = "Ya_123456"
            //};
        }

        public async void OnPost(LoginModel loginModel)
        {
            var res = _icuTechService.LoginUser(new LoginModel
            {
                UserName = loginModel.UserName,
                Password = loginModel.Password
            }).Result;

            IsPost = true;
            Result = res.Email is not null;
            if (Result)
            {
                Message = res.ToString();
            }
        }
    }
}