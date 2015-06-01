namespace DS.Web.Controllers {
	using DS.Web.Models.Home;
	using System.Web.Mvc;

	public class HomeController : BaseController {

		#region - actions


		[HttpGet()]
		public ActionResult Index() {
			return this.View(new IndexModel());
		}

		[HttpPost()]
		public ActionResult Index(IndexModel model) {
			// send an email to dylen
			this.SendEmail(model.Form);

			// clear out form
			model.Form = new SignUpForm();

			return this.View(model);
		}


		#endregion

		#region - methods


		private void SendEmail(SignUpForm form) {
			var client = new System.Net.Mail.SmtpClient();
			var message = new System.Net.Mail.MailMessage();
			message.From = new System.Net.Mail.MailAddress("website@dylensmith.com");
			message.To.Add("derrysmith@gmail.com");
			message.Subject = "testing from HomeController";
			message.Body = "this is a test message";
			message.IsBodyHtml = false;

			client.Send(message);
		}


		#endregion

	}
}