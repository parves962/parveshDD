using System;
using System.Collections.Generic;
using System.Text;
using DAC.Decorator;
using EntityModel;
using Data.DBContext;
using System.Linq;
using static System.Exception;
namespace DAC.Db_Operations
{
    public class EventDecorator : EventRepository
    {
        private  ApplicationDbContext _context;
        

        public override List<EventModel>  GetEvent(string email)
        {
            try
            {
                var result = from eve in _context.Event
                             where eve.RegistereEmail == email
                             orderby eve.Date
                             select eve;
                //where eve.id == id
                if(result == null)
                {
                    throw new NoEventException();
                }
                return result.ToList();
            }
            catch(NoEventException e)
            {
                List<EventModel> Nlist = new List<EventModel>();
                Console.WriteLine(e.Message);
                return Nlist;


            }
        }

        public override List<EventModel> PublicEvent()
        {
            try
            {
                var result = from eve in _context.Event
                             where eve.Type == "public"
                             orderby eve.Date
                             select eve;
                //where eve.id == id

                return result.ToList();
            }
            catch(NoPblicEvent e)
            {
                List<EventModel> Nlist = new List<EventModel>();
                Console.WriteLine(e.Message);
                return Nlist;
            }
        }

    }
}
    


