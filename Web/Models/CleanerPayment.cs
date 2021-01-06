using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    #region Index

    public class CleanerPaymentIndexViewModel
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

    public class CleanerPaymentDetailsViewModel
    {
        public int CleanerPaymentID { get; set; }
        public string Remark { get; set; }
        public byte[] ProofImage { get; set; }
        public byte[] ReceiptImage { get; set; }
        public bool IsActive { get; set; }
        public string CreateDate { get; set; }
        public string LastUpdateDate { get; set; }
    }

    #endregion

    #region Create

    public class CleanerPaymentCreateViewModel : CleanerPaymentDetailsViewModel
    {
    }

    #endregion

    #region Update

    public class CleanerPaymentUpdateViewModel : CleanerPaymentDetailsViewModel
    {
    }

    #endregion
}