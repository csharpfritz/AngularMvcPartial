using AngularMvcPartial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularMvcPartial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult WorkingCode()
		{
			return View();
		}

		public ActionResult ClientSetup(int id)
		{
			return View("_MyPartial");
		}

		public JsonResult ClientInformation(int id)
		{
			var view = GetModel();
			return Json(view, JsonRequestBehavior.AllowGet);
		}

		private ClientAccountSetupViewModel GetModel()
		{
			var result = new ClientAccountSetupViewModel();
			result.TenantID = 1;
			result.SiteProcessings = new List<SiteProcessing>() {
				new SiteProcessing { SiteID = 1, SiteName ="Horsham", RegionName = "Pennsylvania", GatewayAPIKey = "1234", CreditCardProcessorID = "4312", ACHProcessorID = "4312 "},
				new SiteProcessing { SiteID = 2, SiteName = "Philadelphia", RegionName = "Pennsylvania", GatewayAPIKey = null, CreditCardProcessorID = null, ACHProcessorID = null},
				new SiteProcessing { SiteID = 3, SiteName = "Camden", RegionName = "New Jersey",  GatewayAPIKey = "4333", CreditCardProcessorID = "343", ACHProcessorID = null},
				new SiteProcessing { SiteID = 4, SiteName = "Trenton", RegionName = "New Jersey", GatewayAPIKey = null, CreditCardProcessorID = "asd", ACHProcessorID = "dsad"},
				new SiteProcessing { SiteID = 5, SiteName = "Wilmington", RegionName = "Delaware", GatewayAPIKey = "2231", CreditCardProcessorID = null, ACHProcessorID = "4433"},
				new SiteProcessing { SiteID = 6, SiteName = "Dover", RegionName = "Delaware", GatewayAPIKey = null, CreditCardProcessorID = null, ACHProcessorID = null}
			};

			return result;
		}
    }
}