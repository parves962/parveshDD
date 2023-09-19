using System;
using System.Collections.Generic;
using System.Text;
using EntityModel;
using Data.DBContext;
using System.Linq;
namespace DAC.Db_Operations
{
    public class EventRepository : IEventRepository
    {
        private readonly ApplicationDbContext _context;

        public EventRepository()
        { }
        public EventRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public int AddEvent(EventModel model,int Id)
        {
            var newEvent = new EventModel()
            {
                Title = model.Title,
                Date = model.Date,
                Location =model.Location,
                StartTime= model.StartTime,
                Type = model.Type,
                Duration = model.Duration,
                Description = model.Description,
                OtherDetails = model.OtherDetails,
                InvitedBy = model.InvitedBy,
                UserId = Id,
                RegistereEmail = model.RegistereEmail
            };

            _context.Event.Add(newEvent);
            _context.SaveChanges();
            return newEvent.Id;
        }

        public virtual List<EventModel>  GetEvent(string email)
        {
            var result = from eve in _context.Event 
                         where eve.RegistereEmail == email 
                         orderby eve.Date
                         select eve;
            //where eve.id == id

            return result.ToList();
        }

        public List<EventModel> AllEvent()
        {
            var result = from eve in _context.Event
                         orderby eve.Date
                         select eve;
            //where eve.id == id

            return result.ToList();
        }

        public  virtual List<EventModel> PublicEvent()
        {
            var result = from eve in _context.Event
                         where eve.Type == "public"
                         orderby eve.Date
                         select eve;
            //where eve.id == id

            return result.ToList();
        }

        public List<EventModel> UpcomingEvent()
        {
            var result = from eve in _context.Event
                         where 
                         eve.Date > DateTime.Now
                         orderby eve.Date
                         select eve;
            //where eve.id == id

            return result.ToList();
        }

        public List<EventModel> PastEvents()
        {
            var result = from eve in _context.Event
                         where eve.Type == "public"
                         & eve.Date < DateTime.Now
                         orderby eve.Date
                         select eve;
            //where eve.id == id

            return result.ToList();
        }


        public List<EventModel> EventInvited(string email)
        {
            var result = _context.Event
                    .Where(x => x.InvitedBy.Contains(email))
                   .Select(x => new EventModel()
                   {
                       Id = x.Id,
                       Title = x.Title,
                       Date = x.Date,
                       Location = x.Location,
                       StartTime = x.StartTime,
                       Type = x.Type,
                       Duration = x.Duration,
                       Description = x.Description,
                       OtherDetails = x.OtherDetails,
                       InvitedBy = x.InvitedBy,
                       UserId = x.UserId,
                       RegistereEmail = x.RegistereEmail
                   }).ToList();
            return result;
        }

        public EventModel GetEventDetails(int id)
        {
            
            var result = _context.Event
                .Where(x => x.Id == id)
                .Select(x => new EventModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Date = x.Date,
                    Location = x.Location,
                    StartTime = x.StartTime,
                    Type = x.Type,
                    Duration = x.Duration,
                    Description = x.Description,
                    OtherDetails = x.OtherDetails,
                    InvitedBy = x.InvitedBy,
                    UserId = x.UserId,
                    RegistereEmail = x.RegistereEmail
                }).FirstOrDefault();
            return result;
        }
        public bool UpdateBookEvent(int id, EventModel model)
        {
            
            var book = _context.Event.FirstOrDefault(x => x.Id == id);
            if (book != null)
            {
                book.Title = model.Title;
                book.Date = model.Date;
                book.Location = model.Location;
                book.StartTime = model.StartTime;
                book.Type = model.Type;
                book.Duration = model.Duration;
                book.Description = model.Description;
                book.OtherDetails = model.OtherDetails;
                book.InvitedBy = model.InvitedBy;
                book.UserId = model.UserId;
                book.RegistereEmail = model.RegistereEmail;

            }
            _context.SaveChanges();
            return true;  
        }

        public bool DeleteBookEvent(int id)
        {
            var book = _context.Event.FirstOrDefault(x => x.Id == id);
            if (book != null)
            {
                _context.Event.Remove(book);
                _context.SaveChanges();
                return true;
            }
            return false;
            
        }

        public int AddComment(CommentModel model)
        {
            var newEvent = new CommentModel()
            {
               UserName = model.UserName,
               id = model.id,
               Comment = model.Comment,
               EventId = model.EventId
                        };

            _context.Comment.Add(newEvent);
            _context.SaveChanges();
            return newEvent.id;
        }
        public List<CommentModel> GetComment(int id)
        {

            var result = from comment in _context.Comment where comment.EventId == id select comment;
            return result.ToList();
        }

        public List<CommentModel> AllComment()
        {

            var result = from comment in _context.Comment  select comment;
            return result.ToList();
        }

        //public List<CommentModel> AllEventWithComment()
        //{

        //    //var result = from comment in _context.Comment where comment.EventId == id select comment;
        //    //return result.ToList();

            
        //    var com = from comment in _context.Comment select comment;
        //    var result = from eve in _context.Event
        //                 orderby eve.Date
        //                 select eve;
            
        //    var data = 
        //}
    }
}

    

