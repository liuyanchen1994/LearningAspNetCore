using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace MvcCookieAuthSample.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult MakeLogin()
        {
            List<Claim> claims = new List<Claim>() {
                new Claim(ClaimTypes.Name,"Damon"),
                new Claim(ClaimTypes.Role,"admin")
            };
            ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));
            return Ok();
        }

        public IActionResult LoginOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok();
        }
    }
}