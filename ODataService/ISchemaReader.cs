using ODataService.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODataService
{
    public interface ISchemaReader
    {
        IEnumerable<DatabaseTable> GetTables(IEnumerable<TableInfo> tableInfos);
    }
}
