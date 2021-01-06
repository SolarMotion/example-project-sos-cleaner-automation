using log4net;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Utility.CustomLogging;
using Business.Models;

namespace Business.BALs
{
    public class BaseBAL
    {
        public readonly DateTime DATE_TIME_NOW = DateTime.Now;

    }
}
