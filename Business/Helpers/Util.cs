using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utility.CustomLogging;

namespace Business.Helpers
{
    public static class Util
    {
        public static void BusinessStart(Object body)
        {
            LogInfo("Business Request", body);
        }

        public static void BusinessEnd(Object body)
        {
            LogInfo("Business Response", body);
        }

        public static T ConstructFailResponse<T>(this T target) where T : BaseResponse
        {
            return target;
        }

        public static T ConstructFailResponse<T>(this T target, string message) where T : BaseResponse
        {
            target.ResponseMessage = message;

            return target;
        }

        public static T ConstructSuccessResponse<T>(this T target) where T : BaseResponse
        {
            target.IsSucess = true;

            return target;
        }
    }
}
