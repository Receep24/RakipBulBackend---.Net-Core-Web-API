using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class PointInfoDto
    {
        public int Id { get; set; }
        public int Points { get; set; }
        public int UserID { get; set; }
        public int EventID { get; set; }
    }
}
