﻿namespace DiversityService.API.WebHost.Filters
{
    using System.Net;
    using System.Web.Http.Controllers;
    using System.Web.Http.Filters;
    using System.Net.Http;
    using System.Linq;

    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (!actionContext.ModelState.IsValid)
            {
                actionContext.Response = actionContext
                    .Request
                    .CreateErrorResponse(
                        HttpStatusCode.BadRequest,
                        actionContext.ModelState
                    );
            }
        }
    }
}