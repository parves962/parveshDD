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
    public class CampController : ControllerBase
    {

        private readonly AppDbContext _authContext;
        public CampController(AppDbContext appDbContext)
        {
            _authContext = appDbContext;
        }

        [HttpPost("addCamp")]
        public async Task<IActionResult> Authenticate([FromBody] Camp campObj)
        {
            if (campObj == null)
                return BadRequest();

            campObj.Flag = false;
            await _authContext.Camps.AddAsync(campObj);
            await _authContext.SaveChangesAsync();

            return Ok(new
            {
                Message = "New Camp Added!"
            });
        }

        [HttpGet("GetCamp")]
        public List<Camp>  GetC()
        { 
             var result =  (from c in _authContext.Camps where c.Flag == false || c.Checkin >= DateTime.Now select c);
            return result.ToList();
            
        }

        [HttpGet("GetById/{id:int}")]
        public List<Camp> GetCamp(int id)
        {
            var result = (from c in _authContext.Camps where c.id == id select c);
            return result.ToList();

        }

        [HttpGet("SearchCamp/{capacity}/{checkin}/{checkout}")]
        public List<Camp> Search(int capacity,DateTime checkin,DateTime checkout)
        {
            var result = from c in this._authContext.Camps where c.Checkin >= checkin && c.Checkout <=checkout && c.Capacity == capacity select c;
            return result.ToList();

        }

        [HttpDelete("DeleteCamp/{id:int}")]
        public async Task<IActionResult> DeleteCamp( int id)
        {
            var camp = this._authContext.Camps.FirstOrDefault(x => x.id == id);
            if (camp != null)
            {
                _authContext.Camps.Remove(camp);
                _authContext.SaveChanges();
                return Ok(new
                {
                    Message = "Deleted!"
                });
            }
            return BadRequest();
        }

        [HttpPut("UpdateCamp/{id:int}")]
        public bool UpdateCamp(int id, Camp model)
        {

            var camp = _authContext.Camps.FirstOrDefault(x => x.id == id);
            if (camp != null)
            {
                camp.Campname = model.Campname;
                camp.Rate = model.Rate;
                camp.Capacity = model.Capacity;
                camp.Desciption = model.Desciption;
                camp.Checkin = model.Checkin;
                camp.Checkout = model.Checkout;
                camp.Image = model.Image;
                camp.TotalStay = model.TotalStay;
            }
            _authContext.SaveChanges();
            return true;
        }
    }
}
