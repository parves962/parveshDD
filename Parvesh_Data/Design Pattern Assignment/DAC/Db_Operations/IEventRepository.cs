using EntityModel;
using System.Collections.Generic;

namespace DAC.Db_Operations
{
    public interface IEventRepository
    {
        int AddEvent(EventModel model,int id);

        List<EventModel> GetEvent(string email);

        List<EventModel> AllEvent();
        List<EventModel> PublicEvent();

        List<EventModel> UpcomingEvent();
        List<EventModel> PastEvents();

        List<EventModel> EventInvited(string email);

        EventModel GetEventDetails(int id);

        bool UpdateBookEvent(int id, EventModel model);

        bool DeleteBookEvent(int id);

        public List<CommentModel> GetComment(int id);

        List<CommentModel> AllComment();
        int AddComment(CommentModel model);
    }
}