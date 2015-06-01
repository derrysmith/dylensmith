namespace DS.Web.Models.Home {
	public class IndexModel : BaseModel {

		#region - properties


		public SignUpForm Form { get; set; }


		#endregion

	}

	public class SignUpForm {

		#region - properties


		public string FName { get; set; }
		public string LName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }


		#endregion

	}
}