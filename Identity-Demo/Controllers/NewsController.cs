using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Identity_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : BaseController
    {
        [Authorize]
        [HttpGet("/api/news")]
        public IActionResult Get()
        {
            return Ok(new { Id = 1, Title = ".Net Core Dersleri", Description = "Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum", UserEmail = GetByEmail() });
        }
    }
}