﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class PointUpdateDTO
    {
        public int Points { get; set; }

        public int UserID { get; set; }
        public int EventID { get; set; }
    }
}
