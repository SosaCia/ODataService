﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ODataService.Model
{
    public class DatabaseColumn
    {
        public string Schema { get; set; }
        public string Table { get; set; }
        public string Name { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool Nullable { get; set; }

        public string DataType { get; set; }
    }
}
