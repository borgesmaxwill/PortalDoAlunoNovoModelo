using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using trabalhoIHC.Controllers;

namespace trabalhoIHC.Filter
{
    public class MessagesActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Check for incoming Toastr objects, in case we've been redirected here
            MessagerBaseController controller = filterContext.Controller as MessagerBaseController;
            if (controller != null)
                controller.Toastr = (controller.TempData["Toastr"] as Toastr)
                                     ?? new Toastr();

            base.OnActionExecuting(filterContext);
        }

        // This method is called AFTER the action method is executed but BEFORE the
        // result is processed (in the view or in the redirection)
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            MessagerBaseController controller = filterContext.Controller as Controllers.MessagerBaseController;
            if (filterContext.Result.GetType() == typeof(ViewResult))
            {
                if (controller.Toastr != null && controller.Toastr.ToastMessages.Count() > 0)
                {
                    // We're going to a view so we store Toastr in the ViewData collection
                    controller.ViewData["Toastr"] = controller.Toastr;
                }
            }
            else if (filterContext.Result.GetType() == typeof(RedirectToRouteResult))
            {
                if (controller.Toastr != null && controller.Toastr.ToastMessages.Count() > 0)
                {
                    // User is being redirected to another action method so we store Toastr in
                    // the TempData collection
                    controller.TempData["Toastr"] = controller.Toastr;
                }
            }

            base.OnActionExecuted(filterContext);
        }
    }
}