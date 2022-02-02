using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DemirSaglik.Project.Web.Attiributes
{
    public class UserNeeded: ActionFilterAttribute
    {
        public UserNeeded()
        {
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var sessionKey = context.HttpContext.Session.GetString("Name");

            if (sessionKey == null)
            {
                context.Result = new RedirectToActionResult("Index", "Home", new { });
            }
        }
    }
}
