using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace EntityModel
{
    public class CommentModel
    {
        public int id { get; set; }

        [ForeignKey("Event")]
        public int EventId { get; set; }

        public string UserName { get; set; }

        public DateTime Timestamp { get; set; }

        public EventModel eventmodel { get; set; }
        public string Comment { get; set; }

        public CommentModel()
        {
            Timestamp = DateTime.Now;
        }
    }
}
