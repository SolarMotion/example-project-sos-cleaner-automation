using log4net;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BALs
{
    public class BaseBAL
    {
        private readonly ILogger _logger;

        public BaseBAL(ILogger<BaseBAL> logger)
        {
            _logger = logger;
        }
        public static readonly ILog LOGGER = LogManager.GetLogger("BusinessLogger");

    }
}
