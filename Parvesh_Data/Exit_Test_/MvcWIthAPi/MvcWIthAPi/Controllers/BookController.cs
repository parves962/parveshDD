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
    public class BookController : ControllerBase
    {
        private readonly AppDbContext _authContext;

        
        public BookController(AppDbContext appDbContext)
        {
            _authContext = appDbContext;
        }

        private static Random random = new Random();



        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [HttpPost("addBook")]
        public async Task<IActionResult> Authenticate([FromBody] Book bookObj)
        {
            if (bookObj == null)
                return BadRequest();

            var res = _authContext.Camps.Where(x => x.id == bookObj.Campid);

   

            bookObj.BRN = RandomString(3);

            var camp = _authContext.Camps.FirstOrDefault(x => x.id == bookObj.Campid);
            if (camp != null)
            {
                camp.Campname = camp.Campname;
                camp.Rate = camp.Rate;
                camp.Capacity = camp.Capacity;
                camp.Desciption = camp.Desciption;
                camp.Checkin = camp.Checkin;
                camp.Checkout = camp.Checkout;
                camp.Image = camp.Image;
                camp.TotalStay = camp.TotalStay;
                camp.Flag = true;
                camp.UserCounter += 1;
            }
            _authContext.SaveChanges();

            await _authContext.Book.AddAsync(bookObj);
            await _authContext.SaveChangesAsync();

            return Ok(new
            {
                Message = bookObj.BRN
            }) ;
        }

        [HttpGet("SearchBook/{RefrenceNo}")]
        public async Task<IList<Book>> Search(string RefrenceNo)
        {
            var result = await _authContext.Book.Where(x => x.BRN == RefrenceNo).ToListAsync();
            return  result;

        }

        [HttpGet("GetById/{id:int}")]
        public async Task<IList<Book>> GetBook(int id)
        {
            var result = await _authContext.Book.Where(x => x.id == id).ToListAsync();
            return result;

        }

        [HttpDelete("DeleteBook/{id:int}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = this._authContext.Book.FirstOrDefault(x => x.id == id);
            if (book != null)
            {
                _authContext.Book.Remove(book);
                _authContext.SaveChanges();
                return Ok(new
                {
                    Message = "Deleted!"
                });
            }
            return BadRequest();
        }

        [HttpDelete("DeleteBooking/{id:int}/{campId:int}/{r:int}")]
        public async Task<IActionResult> DeleteBooking(int? id, int? campId,int r)
        {
            if (id == null)
                return BadRequest("Id is not valid");

            var result = await _authContext.Book.FirstOrDefaultAsync(x => x.id == id);

            var camp = await _authContext.Camps.FirstOrDefaultAsync(x => x.id == campId);
            if (camp != null)
            {
                camp.Campname = camp.Campname;
                camp.Rate = camp.Rate;
                camp.Capacity = camp.Capacity;
                camp.Desciption = camp.Desciption;
                camp.Checkin = camp.Checkin;
                camp.Checkout = camp.Checkout;
                camp.Image = camp.Image;
                camp.TotalStay = camp.TotalStay;
                camp.Flag = false;
                camp.AverageRating = (float)(camp.AverageRating + r)/camp.UserCounter;
               
            }
            _authContext.SaveChanges();

            _authContext.Remove(result);
            await _authContext.SaveChangesAsync();
            return Ok(new { Message = "Delete Successfull." });
        }

        [HttpDelete("UpdateBooking/{id:int}/{campId:int}/{r:int}")]
        public async Task<IActionResult> UpdateBooking(int? id, int? campId, int r)
        {
            if (id == null)
                return BadRequest("Id is not valid");

            var result = await _authContext.Book.FirstOrDefaultAsync(x => x.id == id);

            var camp = await _authContext.Camps.FirstOrDefaultAsync(x => x.id == campId);
            if (camp != null)
            {
                camp.Campname = camp.Campname;
                camp.Rate = camp.Rate;
                camp.Capacity = camp.Capacity;
                camp.Desciption = camp.Desciption;
                camp.Checkin = camp.Checkin;
                camp.Checkout = camp.Checkout;
                camp.Image = camp.Image;
                camp.TotalStay = camp.TotalStay;
               // camp.Flag = false;
                camp.AverageRating = (float)(camp.AverageRating + r) / camp.UserCounter;
                camp.OverallRating += r;
            }
            _authContext.SaveChanges();

            _authContext.Remove(result);
            await _authContext.SaveChangesAsync();
            return Ok(new { Message = "Delete Successfull." });
        }

    }

}

    

