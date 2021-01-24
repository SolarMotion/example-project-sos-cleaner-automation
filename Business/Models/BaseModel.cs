using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class BaseRequest
    {
        public int LastAccessID { get; set; }
    }

    public class BaseResponse
    {
        public bool IsSucess { get; set; }
        public string ResponseMessage { get; set; } = "Invalid result. Please contact administrator.";
    }
}
