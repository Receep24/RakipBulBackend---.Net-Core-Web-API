using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class CommentInfoDto
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public int UserID { get; set; }
        public int EventID { get; set; }
     

        public EventsInfoDto Events { get; set; }
        public UserProfileDto User { get; set; }
    }
}
