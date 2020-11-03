using System;
using System.Collections.Generic;
using System.Text;

namespace ODataService.Model
{
    public class DatabaseTable
    {
        public string Name { get; set; }
        public string Schema { get; set; }
        public IEnumerable<DatabaseColumn> Columns { get; set; }
    }
}
