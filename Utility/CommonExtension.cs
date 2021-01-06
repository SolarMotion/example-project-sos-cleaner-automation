using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Net.Mime;

namespace Utility
{
    public static class CommonExtension
    {
        //CHIEN: here
        //public static MediaTypeNames.Image ConvertToImage(Binary iBinary)
        //{
        //    var arrayBinary = iBinary.ToArray();
        //    Image rImage = null;

        //    using (MemoryStream ms = new MemoryStream(arrayBinary))
        //    {
        //        rImage = Image.FromStream(ms);
        //    }

        //    return rImage;
        //}

        public static bool IsEmpty(this byte[] value)
        {
            return !(value != null && value.Length > 0);
        }

        public static bool IsEmpty(this Object value)
        {
            return value == null;
        }

        public static string ToBoolFlag(this bool value)
        {
            return value ? "Yes" : "No";
        }

        public static string ToDateTimeString(this DateTime value)
        {
            return value.ToDateTimeString();
        }

        public static string ToDateTimeString(this DateTime? value)
        {
            return value.HasValue ? value.ToDateTimeString() : "";
        }

        public static string ToString2(this Object value)
        {
            return value == null ? "" : value.ToString();
        }

        public static int ToInt(this string value)
        {
            var isInt = int.TryParse(value, out int result);

            if (isInt)
                return result;

            return 0;
        }
    }
}
