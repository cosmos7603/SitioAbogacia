using AM.Services;

namespace AM.WebSite
{
	public class ActiveHeadOffice
	{
		#region Properties
		public string HeadOfficeCode { get; set; }
		public string HeadOfficeName { get; set; }
		#endregion

		#region Methods
		public static ActiveHeadOffice Create(string headOfficeCode)
		{
			var HeadOffice = HeadOfficeService.GetHeadOffice(headOfficeCode);

			// Create active user
			var activeHeadOffice = new ActiveHeadOffice()
			{
				HeadOfficeCode = HeadOffice.HoCode,
				HeadOfficeName = HeadOffice.HoName
			};

			return activeHeadOffice;
		}
		#endregion
	}
}