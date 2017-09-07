using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutherFilters.Controllers
{
    
    public class AuthController : Controller
    {
        //[TestAuthenticationAttribute]
        //[AutherizationAttribute]
        //[OutputCache(Duration=10)]
        //[TestActionAttribute]
        //[ExeptionFilter]
        [ResultExecutionFilter]
        // GET: Auth
        public ActionResult Index()
        {
            //try
            //{
            //    throw new NotImplementedException();
            //}
            //catch
            //{
            //    throw;
            //}
            //string str;
            return View();

        }
    }
}