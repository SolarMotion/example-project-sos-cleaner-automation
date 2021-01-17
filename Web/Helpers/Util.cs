using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Utility.CommonExtension;

namespace Web.Helpers
{
    public static class Util
    {
        #region Session

        public static int SessionLastAccessID
        {
            get
            {
                return HttpContext.Current.Session["LastAccessID"].ToString2().ToInt();
            }
            set
            {
                HttpContext.Current.Session["LastAccessID"] = value;
            }
        }

        #endregion

        #region Web (Display)

        public static void CreateSuccessMsg(Controller controller, string message)
        {
            controller.TempData["SuccessMsg"] = message;
        }

        public static void CreateErrorMsg(Controller controller, string message)
        {
            controller.TempData["ErrorMsg"] = message;
        }

        public static void CreateWarningMsg(Controller controller, string message)
        {
            controller.TempData["WarningMsg"] = message;
        }

        #endregion
    }
}