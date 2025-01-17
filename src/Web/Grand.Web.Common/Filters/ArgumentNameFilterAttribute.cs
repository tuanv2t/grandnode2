﻿using Microsoft.AspNetCore.Mvc.Filters;

namespace Grand.Web.Common.Filters
{
    public class ArgumentNameFilterAttribute : ActionFilterAttribute
    {
        public string KeyName { get; set; }
        public string Argument { get; set; }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.ActionArguments[Argument] = context.HttpContext.Request.Form.Keys.Any(key => key.Equals(KeyName));
        }
    }
}
