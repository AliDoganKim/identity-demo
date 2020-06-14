using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Identity_Demo.Controllers
{
    public class BaseController : ControllerBase
    {
        public string GetByEmail()
        {
            var claims = from c in User.Claims.Where(f => f.Type.Contains("emailaddress")) select new { c.Type, c.Value };
            if (!claims.Any())
                return null;
            return claims?.FirstOrDefault().Value;
        }
    }
}