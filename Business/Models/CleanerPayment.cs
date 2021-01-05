using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    #region Create

    public class CleanerPaymentCreateRequest : BaseRequest
    {
        public string Remark { get; set; }
        public byte ProffImage { get; set; }
    }

    public class CleanerPaymentCreateResponse : BaseRequest
    {
        public int CleanerPaymentID { get; set; }
    }

    #endregion

    #region Update

    public class CleanerPaymentUpdateRequest : BaseRequest
    {
        public int CleanerPaymentID { get; set; }
        public string Remark { get; set; }
        public byte ReceiptImage { get; set; }
    }

    public class CleanerPaymentUpdateResponse : BaseRequest
    {
        public int CleanerPaymentID { get; set; }
    }

    #endregion
}
