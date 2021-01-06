using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Business.Models;
using static Utility.CustomLogging;

namespace Business.BALs
{
    public class CleanerEmailBAL : BaseBAL
    {
        public CleanerPaymentIndexResponse Index(CleanerPaymentIndexRequest request)
        {
            var response = new CleanerPaymentIndexResponse();
            Start(request);

            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                End(response);
            }

            return response;
        }

        public CleanerPaymentCreateResponse Create(CleanerPaymentCreateRequest request)
        {
            var response = new CleanerPaymentCreateResponse();

            return response;
        }

        public CleanerPaymentUpdateResponse Update(CleanerPaymentUpdateRequest request)
        {
            var response = new CleanerPaymentUpdateResponse();

            return response;
        }
    }
}
