using System;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;
using Sitio.Models;

namespace Sitio.Controllers
{
	[Route("Home/{action=index}")]
	public class HomeController : Controller
	{
		// GET: home
		public ActionResult Index()
		{
			var model = new ContactModel();
			return View(model);
		}

		public ActionResult SendEmail(ContactModel model)
		{
			if (ModelState.IsValid)
			{
				try
				{
					const string body = "<p>Email de: {0} ({1})<p>Teléfon:{4}</p><p>Asunto: {2}</p></p><p>Mensaje:</p><p>{3}</p>";
					var message = new MailMessage();
					message.To.Add(new MailAddress("daniel.lipchak7603@gmail.com"));
					//message.To.Add(new MailAddress("sebastianlopezgiacomelli@gmail.com"));
					message.From = new MailAddress(model.EmailAddress); // replace with valid value
					message.Subject = model.Subject;
					message.Body = string.Format(body, model.Name, model.EmailAddress, model.Subject, model.Message, model.Telephone);
					message.IsBodyHtml = true;
					using (var smtp = new SmtpClient())
					{
						var credential = new NetworkCredential
						{
							UserName = "daniel.lipchak7603@gmail.com",
							Password = "coco300=coco300"
						};
						smtp.Credentials = credential;
						smtp.Host = "smtp.gmail.com";
						smtp.Port = 587;
						smtp.EnableSsl = true;
						smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
						smtp.Send(message);
						return Json(new { success = true });
					}
				}
				catch (Exception ex)
				{
					return Json(new { success = false, error = ex.Message });
				}


			}
			else
			{
				return Json(new { success = false });
			}

		}




	}
}
