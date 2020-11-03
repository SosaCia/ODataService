using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODataService
{
    public interface IDataService
    {
        EdmEntityObjectCollection Get(IEdmCollectionType collectionType, ODataQueryOptions queryOptions);

        EdmEntityObject Get(string key, IEdmEntityType entityType);

        int Count(IEdmCollectionType collectionType, ODataQueryOptions queryOptions);
    }
}
