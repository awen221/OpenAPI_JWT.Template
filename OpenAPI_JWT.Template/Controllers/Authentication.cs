using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace OpenAPI.JWT.Template.Controllers
{
    using OpenAPI.JWT.Core;

    /// <summary>
    /// AuthenticationController
    /// </summary>
    [Route("[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class Authentication : JWT.Controllers.Authentication
    {
        /// <summary>
        /// AuthenticationController
        /// </summary>
        /// <param name="jwtAuthManager"></param>
        public Authentication(AuthManagerInterface jwtAuthManager) : base(jwtAuthManager) { }

        /// <summary>
        /// 登入
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public override IActionResult Login(string UserName, string Password) => base.Login(UserName, Password);
        /// <summary>
        /// 更新憑證
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public override async Task<IActionResult> RefreshToken([FromBody]string request) => await base.RefreshToken(request);
        /// <summary>
        /// 取得當前使用者
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public override IActionResult GetCurrentUser() => base.GetCurrentUser();
        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public override IActionResult Logout() => base.Logout();
    }
}