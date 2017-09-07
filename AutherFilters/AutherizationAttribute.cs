using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutherFilters
{
    public class AutherizationAttribute : FilterAttribute, IAuthorizationFilter

    {
        private string _role;
        public AutherizationAttribute(params string[] roles)
        {
           // _role = roles;
        }
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            throw new NotImplementedException();
        }
    }
}