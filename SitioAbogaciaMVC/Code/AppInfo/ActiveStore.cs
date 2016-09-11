namespace AM.WebSite
{
	public class ActiveStore
	{
		#region Properties
		public int StoreId { get; set; }
		public string StoreName { get; set; }
		public string InvoiceStoreName { get; set; }
		public string BrandCode { get; set; }
        public bool FullVersion { get; set; }
        public bool EnableBranches { get; set; }
		public bool Virtuoso { get; set; }
		#endregion

		#region Methods
		public static ActiveStore Create(int storeId)
		{
			return null;
		}
		#endregion
	}
}