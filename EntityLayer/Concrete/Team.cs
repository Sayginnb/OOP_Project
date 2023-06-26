﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Team
    {
        public int TeamId { get; set; }
        public string PersonName { get; set; }
        public int Title { get; set; }
        public int ImageUrl { get; set; }
        public int FacebookUrl { get; set; }
        public int InstagramUrl { get; set; }
        public int WebSiteUrl { get; set; }
        public int TwitterUrl { get; set; }
    }
}
