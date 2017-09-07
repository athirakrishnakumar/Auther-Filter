using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutherFilters
{
    public class ExeptionFilter : FilterAttribute, IExceptionFilter
    {


        public void OnException(ExceptionContext filterContext)
        {
            //throw new NotImplementedException();
        }

    }
}