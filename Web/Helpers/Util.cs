using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Utility.CommonExtension;

namespace Web.Helpers
{
    public static class Util
    {
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
    }
}