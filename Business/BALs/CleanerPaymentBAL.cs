using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Business.Models;
using static Utility.CustomLogging;
using Data;
using static Utility.CommonExtension;
using static Business.Helpers.Util;

namespace Business.BALs
{
    public class CleanerEmailBAL : BaseBAL
    {
        public CleanerPaymentIndexResponse Index(CleanerPaymentIndexRequest request)
        {
            var response = new CleanerPaymentIndexResponse();
            BusinessStart(request);

            try
            {
                using (var db = new DatabaseEntities())
                {
                    var trnCleanerPaymentProof = db.trnCleanerPaymentProofs.OrderByDescending(a => a.ID).Take(500).ToList();

                    response.Payments = trnCleanerPaymentProof.Select(a => new CleanerPaymentIndexItem()
                    {
                        IsActiveFlag = a.IsActive.ToBoolFlag(),
                        CleanerPaymentID = a.ID,
                        CreateDate = a.CreateDT.ToDateTimeString(),
                        IsPaidFlag = a.ProofImage.IsEmpty().ToBoolFlag(),
                        LastUpdateDate = a.LastUpdateDT.ToDateTimeString(),
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
            finally
            {
                BusinessEnd(response);
            }

            return response.ConstructSuccessResponse();
        }

        public CleanerPaymentDetailsResponse Details(CleanerPaymentDetailsRequest request)
        {
            var response = new CleanerPaymentDetailsResponse();
            BusinessStart(request);

            try
            {
                using (var db = new DatabaseEntities())
                {
                    #region Validation

                    var trnCleanerPaymentProof = db.trnCleanerPaymentProofs.FirstOrDefault(a => a.ID == request.CleanerPaymentID);
                    if (trnCleanerPaymentProof.IsEmpty())
                        return response.ConstructFailResponse("Invalid ID");

                    #endregion

                    response.CleanerPaymentID = trnCleanerPaymentProof.ID;
                    response.CreateDate = trnCleanerPaymentProof.CreateDT.ToDateTimeString();
                    response.LastUpdateDate = trnCleanerPaymentProof.LastUpdateDT.ToDateTimeString();
                    response.ProofImage = trnCleanerPaymentProof.ProofImage;
                    response.ReceiptImage = trnCleanerPaymentProof.ReceiptImage;
                    response.IsActive = trnCleanerPaymentProof.IsActive;
                    response.Remark = trnCleanerPaymentProof.Remark;
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
            finally
            {
                BusinessEnd(response);
            }

            return response.ConstructSuccessResponse();
        }

        public CleanerPaymentCreateResponse Create(CleanerPaymentCreateRequest request)
        {
            var response = new CleanerPaymentCreateResponse();
            BusinessStart(request);

            try
            {
                using (var db = new DatabaseEntities())
                {
                    #region Validation

                    if (request.ProofImage.IsEmpty())
                        return response.ConstructFailResponse("Proof Image is empty.");

                    #endregion

                    var trnCleanerPaymentProof = new trnCleanerPaymentProof()
                    {
                        Remark = request.Remark,
                        ProofImage = request.ProofImage,
                        IsActive = true,
                        CreateDT = DATE_TIME_NOW,
                        LastAccessID = request.LastAccessID,
                    };
                    db.trnCleanerPaymentProofs.Add(trnCleanerPaymentProof);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
            finally
            {
                BusinessEnd(response);
            }

            return response.ConstructSuccessResponse();
        }

        public CleanerPaymentUpdateResponse Update(CleanerPaymentUpdateRequest request)
        {
            var response = new CleanerPaymentUpdateResponse();
            BusinessStart(request);

            try
            {
                using (var db = new DatabaseEntities())
                {
                    #region Validation

                    var trnCleanerPaymentProof = db.trnCleanerPaymentProofs.FirstOrDefault(a => a.ID == request.CleanerPaymentID);
                    if (trnCleanerPaymentProof.IsEmpty())
                        return response.ConstructFailResponse("Invalid ID");

                    #endregion

                    trnCleanerPaymentProof.ReceiptImage = request.ReceiptImage;
                    trnCleanerPaymentProof.IsActive = request.IsActive;
                    trnCleanerPaymentProof.Remark = request.Remark;
                    trnCleanerPaymentProof.LastUpdateDT = DATE_TIME_NOW;

                    db.SaveChanges();

                    response.CleanerPaymentID = trnCleanerPaymentProof.ID;
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }
            finally
            {
                BusinessEnd(response);
            }

            return response.ConstructSuccessResponse();
        }
    }
}
