using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace IssueTracker.API
{
    public class BasicAuthenticationFilter : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, "Please send credentials");
            }
            else
            {
                string autheticationToken = actionContext.Request.Headers.Authorization.Parameter;
            }
        }
    }
}