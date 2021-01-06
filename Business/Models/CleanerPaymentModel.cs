using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    #region Index

    public class CleanerPaymentIndexRequest : BaseRequest
    {
    }

    public class CleanerPaymentIndexResponse : BaseResponse
    {
        public List<CleanerPaymentIndexItem> Payments { get; set; } = new List<CleanerPaymentIndexItem>();
    }

    public class CleanerPaymentIndexItem
    {
        public int CleanerPaymentID { get; set; }
        public string IsPaidFlag { get; set; }
        public string IsActiveFlag { get; set; }
        public string CreateDate { get; set; }
        public string LastUpdateDate { get; set; }
    }

    #endregion

    #region Details

    public class CleanerPaymentDetailsRequest : BaseRequest
    {
        public int CleanerPaymentID { get; set; }
    }

    public class CleanerPaymentDetailsResponse : BaseResponse
    {
        public int CleanerPaymentID { get; set; }
        public bool IsActive { get; set; }
        public string CreateDate { get; set; }
        public string LastUpdateDate { get; set; }
        public string Remark { get; set; }
        public byte[] ProofImage { get; set; }
        public byte[] ReceiptImage { get; set; }
    }

    #endregion

    #region Create

    public class CleanerPaymentCreateRequest : BaseRequest
    {
        public string Remark { get; set; }
        public byte[] ProofImage { get; set; }
    }

    public class CleanerPaymentCreateResponse : BaseResponse
    {
        public int CleanerPaymentID { get; set; }
    }

    #endregion

    #region Update

    public class CleanerPaymentUpdateRequest : BaseRequest
    {
        public int CleanerPaymentID { get; set; }
        public bool IsActive { get; set; }
        public string Remark { get; set; }
        public byte[] ReceiptImage { get; set; }
    }

    public class CleanerPaymentUpdateResponse : BaseResponse
    {
        public int CleanerPaymentID { get; set; }
    }

    #endregion
}
