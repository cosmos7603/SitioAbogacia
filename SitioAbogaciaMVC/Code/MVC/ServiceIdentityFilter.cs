using AM.Services;
using AM.Services.Models;
using System.Web.Mvc;

namespace AM.WebSite.Code.MVC
{
	public class ServiceIdentityFilter : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext actionContext)
		{
			if (AppInfo.ActiveUser == null)
				return;

			var userIdentity = new ServiceUserIdentity
			{
				AuditLogin = AppInfo.AuditLogin,
				Login = AppInfo.ActiveUser.Login,
				UserLevelCode = AppInfo.ActiveUser.UserLevelCode,
				UserName = AppInfo.ActiveUser.UserName,
				Email = AppInfo.ActiveUser.Email,
				StoreId = AppInfo.ActiveUser.StoreId,
				BrandCode = AppInfo.ActiveUser.BrandCode,
				HoCode = AppInfo.ActiveUser.HoCode,
				IsEnacting = AppInfo.ActiveUser.IsEnacting,
				ClientMinutesOffset = AppInfo.ActiveUser.ClientMinutesOffset
			};

			// Tell the service layer which identity use for this request
			ServiceBase.SetIdentity(userIdentity);
		}
	}
}
