using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityModel
{
    public class EventModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public System.DateTime Date { get; set; }
        [Required]
        public string Location { get; set; }
        public string StartTime { get; set; }
        public string Type { get; set; }
        [Required]
        public string Duration { get; set; }
        public string Description { get; set; }
        public string OtherDetails { get; set; }
        public string InvitedBy { get; set; }
        public int UserId { get; set; }
        [Required]
        public string RegistereEmail { get; set; }

        [ForeignKey("EventId")]
        public ICollection<CommentModel> Comment { get; set; }

    }
}
