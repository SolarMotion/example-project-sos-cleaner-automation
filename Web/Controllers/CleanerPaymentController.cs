using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Utility.CustomLogging;
using Business.Models;
using Business.BALs;
using Web.Models;

namespace Web.Controllers
{
    public class CleanerPaymentController : BaseController
    {
        private readonly CleanerEmailBAL BAL = new CleanerEmailBAL();

        public ActionResult Index()
        {
            var viewModel = new CleanerPaymentIndexViewModel();

            var response = BAL.Index(new CleanerPaymentIndexRequest());

            if (response.IsSucess)
            {
                viewModel.Payments = response.Payments.Select(a => new Models.CleanerPaymentIndexItem()
                {
                    CleanerPaymentID = a.CleanerPaymentID,
                    CreateDate = a.CreateDate,
                    IsPaidFlag = a.IsPaidFlag,
                    LastUpdateDate = a.LastUpdateDate,
                    IsActiveFlag = a.IsActiveFlag,
                }).ToList();
            }
            else
            {
                //CHIEN: show error
            }

            return View(viewModel);
        }

        public ActionResult Details(int cleanerPaymentID)
        {
            var viewModel = new CleanerPaymentDetailsViewModel();

            var response = BAL.Details(new CleanerPaymentDetailsRequest() { CleanerPaymentID = cleanerPaymentID, });

            if (response.IsSucess)
            {
                viewModel.CleanerPaymentID = response.CleanerPaymentID;
                viewModel.CreateDate = response.CreateDate;
                viewModel.LastUpdateDate = response.LastUpdateDate;
                viewModel.ProofImage = response.ProofImage;
                viewModel.ReceiptImage = response.ReceiptImage;
                viewModel.IsActive = response.IsActive;
                viewModel.Remark = response.Remark;
            }
            else
            {
                //CHIEN: show error
            }

            return View(viewModel);
        }

        public ActionResult Create()
        {
            return View(new CleanerPaymentCreateViewModel());
        }

        [HttpPost]
        public ActionResult Create(CleanerPaymentCreateViewModel viewModel)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Update(int cleanerPaymentID)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(CleanerPaymentUpdateViewModel viewModel)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
