using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters.Models
{
    public class ClientModel
    {
        
        public int MyProperty { get; set; }

        [AllowHtml] // HTML Code Allow in this property.
        public string Data { get; set; }
    }
}