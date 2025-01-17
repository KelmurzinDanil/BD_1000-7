﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_993
{
    internal class Recommendations
    {
        public int Id { get; set; }
        public int Id_Realty { get; set; }
        [ForeignKey("ReltyInIdRec")]
        public Realty? Realty_id { get; set; }

        public int Mark_Realty { get; set; }
        [ForeignKey("ReltyInMarkRec")]
        public Realty? Realty_mark { get; set; }
    }
}
