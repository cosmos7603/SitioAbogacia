using AM.Services;

namespace AM.WebSite
{
	public class ActiveBrand
	{
		#region Properties
		public string BrandCode { get; set; }
		public string BrandName { get; set; }
		public string HeadOfficeCode { get; set; }
		public bool Berthing { get; set; }
		#endregion

		#region Methods
		public static ActiveBrand Create(string brandCode)
		{
			var brand = BrandService.GetBrand(brandCode);

			// Create active user
			var activeBrand = new ActiveBrand()
			{
				BrandCode = brand.BrandCode,
				BrandName = brand.BrandName,
				HeadOfficeCode = brand.HoCode,
				Berthing = brand.Berth
			};

			return activeBrand;
		}
		#endregion
	}
}