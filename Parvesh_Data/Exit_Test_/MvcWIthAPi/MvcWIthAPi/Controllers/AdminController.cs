using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcWIthAPi.DataAccessLayer.Context;
using MvcWIthAPi.PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWIthAPi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly AppDbContext _authContext;
        public AdminController(AppDbContext appDbContext)
        {
            _authContext = appDbContext;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] Admin adminObj )
        {
            if (adminObj == null)
                return BadRequest();

            var admin = await _authContext.Admins.FirstOrDefaultAsync(x => x.Email == adminObj.Email && x.Password == adminObj.Password);

            if(admin == null)
            {
                return NotFound(new { Message = "User Not Found!" });
            }

            return Ok(new
            {
                Message = "Login Success!"
            });
        }


       
    }
}
