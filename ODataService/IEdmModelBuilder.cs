using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Text;

namespace ODataService
{
    public interface IEdmModelBuilder
    {
        EdmModel GetModel();
    }
}
