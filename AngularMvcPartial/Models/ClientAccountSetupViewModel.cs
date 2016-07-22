using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularMvcPartial.Models
{
	public class ClientAccountSetupViewModel
	{
		public int TenantID { get; set; }

		public List<SiteProcessing> SiteProcessings { get; set; }
	}

	public class SiteProcessing
	{
		public int SiteID { get; set; }
		public string SiteName { get; set; }
		public string RegionName { get; set; }
		public string GatewayAPIKey { get; set; }
		public string CreditCardProcessorID { get; set; }
		public string ACHProcessorID { get; set; }
	}
}