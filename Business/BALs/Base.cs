using log4net;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utility.CustomLogging;

namespace Business.BALs
{
    public class BaseBAL
    {
        public void Start(Object body)
        {
            LogInfo("Business Request", body);
        }

        public void End(Object body)
        {
            LogInfo("Business Response", body);
        }
    }
}
