using System;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;
using Sitio.Models;

namespace Sitio.Controllers
{
	[Route("Home/{action=index}")]
	public class ServicesController : Controller
	{
		// GET: home
		public ActionResult Index(string service)
		{
			var longDesc = "";
			switch (service)
			{
				case "accidentesEnTransportePublico":
					longDesc =
						@"Si usted o algún familiar/ amigo ha sufrido un accidente mientras viajaba en un medio de transporte público (colectivo, tren, taxi, remis o subte), debe asesorarse con profesionales de su confianza que le brinden el mejor servicio al menor costo. Le garantizamos un trámite rápido y la mejor atención para gestionar su indemnización brindándole un seguimiento constante de la evolución de su caso. Tenga presente que no siempre es necesario ir a juicio para lograr el cobro de lo que le corresponde, es por eso que nuestros servicios se adaptan a las necesidades de nuestros clientes a través de un contacto permanente.
						Es posible que las lesiones sufridas en un accidente de tránsito no aparenten gravedad y no exista intervención médica en el lugar. En esos casos es fundamental que usted busque atención médica inmediatamente después del accidente. Tal vez usted crea que el choque fue menor y que el mismo no produjo un daño en su salud, pero debe tener presente que algunas lesiones (aunque usted no sienta dolor inicialmente o no resulten visibles) se manifiestan varios días después del siniestro. Si usted deja pasar tiempo sin recibir atención médica, únicamente logrará que la compañía de seguros disminuya su indemnización al reclamar lesiones. Tenga presente que al ser atendido siempre debe reclamar las constancias médicas y todos los estudios que le hayan realizado. (vea ¿Cuánto se cobra por lesiones como la cervicalgia o esguince cervical?).
						Siempre recordamos a nuestros clientes, la importancia ante estos sucesos de contar con toda la información posible a su alcance. Es por ello, que recomendamos tomar los datos del transporte donde usted viajaba al producirse el accidente, de testigos y otras víctimas del siniestro y de cualquier otro vehículo involucrado. También resaltamos la importancia de tomar fotos en donde se pueda apreciar la zona en que cada vehículo sufrió daños.
						Por último, le recomendamos que no firme acuerdos directamente con la aseguradora. El negocio de las empresas de seguros es pagarle a usted lo menos posible. Es por eso que harán parecer justa la suma que le ofrecen, pero lo único que buscan es cerrar el tema por la mínima cantidad posible.
						Cuando usted se asesora con nosotros, debe saber que contamos con el conocimiento necesario para que la compañía de seguros asuma la responsabilidad del choque y que le pague el máximo obtenible. Nuestro importante caudal de reclamos facilita imponer al seguro condiciones de negociación más favorables para usted. Tenga presente además que las compañías de seguro pagan por riesgo judicial. Es decir que cuando interviene un abogado, el seguro, ante la posibilidad de afrontar un juicio, termina pagándole más para evitar los costos del mismo.
						Recuerde que usted cuenta con dos años para iniciar el reclamo. No deje pasar el tiempo y reciba lo que le corresponde.";
					break;
				case "accidentesEnAuto":
					longDesc =
						@"Es importante remarcar, que cuando se inicia un reclamo ante una compañía de seguros, de realizarlo con la representación de un abogado, usted siempre percibirá un monto indemnizatorio superior (vea ¿Cuánto se cobra de indemnización por un accidente de tránsito?).
						Si usted o algún familiar/ amigo ha sufrido un accidente con su vehículo ya sea por culpa de un tercero o compartida, usted posee el derecho de realizar el reclamo de una indemnización justa, a fin de resarcir los daños materiales, físicos y morales que pudiese haber padecido.
						Por esa razón, usted debe asesorarse con profesionales de su confianza que le brinden el mejor servicio al menor costo. Le garantizamos un trámite rápido y la mejor atención para gestionar su indemnización brindándole un seguimiento constante de la evolución de su caso. Tenga presente que no siempre es necesario ir a juicio para lograr el cobro de lo que le corresponde, es por eso que nuestros servicios se adaptan a las necesidades de nuestros clientes a través de un contacto permanente. 
						---Es posible que las lesiones sufridas en un accidente de tránsito no aparenten gravedad y no exista intervención médica en el lugar. En esos casos es fundamental que usted/ y sus acompañantes busquen atención médica inmediatamente después del accidente. Tal vez usted crea que el choque fue menor y que el mismo no produjo un daño en su salud, pero debe tener presente que algunas lesiones (aunque usted no sienta dolor inicialmente o no resulten visibles ) se manifiestan varios días después del siniestro. Si usted deja pasar tiempo sin recibir atención médica, únicamente logrará que la compañía de seguros disminuya su indemnización al reclamar lesiones. tenga presente que al ser atendido siempre debe reclamar las constancias médicas y todos los estudios que le hayan realizado. (vea ¿Cuánto se cobra por lesiones como la cervicalgia o esguince cervical?).
						Siempre recordamos a nuestros clientes, la importancia ante estos sucesos de contar con toda la información posible a su alcance. Es por ello, que recomendamos tomar los datos del transporte donde se produjo el accidente, de testigos y otras víctimas del siniestro y de cualquier otro vehículo involucrado. También resaltamos la importancia de tomar fotos en donde se pueda apreciar la zona en que cada vehículo sufrió daños.
						Por último, le recomendamos que no firme acuerdos directamente con la aseguradora. El negocio de las empresas de seguros es pagarle a usted lo menos posible. Es por eso que harán parecer justa la suma que le ofrecen, pero lo único que buscan es cerrar el tema por la mínima cantidad posible. 
						Cuando usted se asesora con nosotros debe saber que contamos con el conocimiento necesario para que la compañía de seguros asuma la responsabilidad del choque y que le pague el máximo obtenible. Nuestro importante caudal de reclamos facilita imponer al seguro condiciones de negociación más favorables para usted. Tenga presente además que las compañías de seguro pagan por riesgo judicial. Es decir que cuando interviene un abogado, el seguro, ante la posibilidad de afrontar un juicio, termina pagándole más para evitar los costos del mismo.
						Recuerde que usted cuenta con dos años para iniciar el reclamo. No deje pasar el tiempo y reciba lo que le corresponde.";
					break;

				case "accidentesEnMoto":
					longDesc =
						@"Es importante remarcar, al iniciar un reclamo ante una compañía de seguros, que de realizarlo con la representación de un abogado especializado, usted siempre percibirá un monto indemnizatorio mayor (vea ¿Cuánto se cobra de indemnización por un accidente de tránsito?).
						Si usted o algún familiar/ amigo ha sufrido un accidente con su vehículo ya sea por culpa de un tercero o compartida, usted posee el derecho de realizar el reclamo de una indemnización justa, a fin de resarcir los daños materiales, físicos y morales que pudiese haber padecido.
						Por esa razón usted debe asesorarse con profesionales de su confianza que le brinden el mejor servicio al menor costo. Le garantizamos un trámite rápido y la mejor atención para gestionar su indemnización brindándole un seguimiento constante de la evolución de su caso. Tenga presente que no siempre es necesario ir a juicio para lograr el cobro de lo que le corresponde, es por eso que nuestros servicios se adaptan a las necesidades de nuestros clientes a través de un contacto permanente. 
						---Es posible que las lesiones sufridas en un accidente de tránsito no aparenten gravedad y no exista intervención médica en el lugar. En esos casos es fundamental que usted/ y sus acompañantes busquen atención médica inmediatamente después del accidente. Tal vez usted crea que el choque fue menor y que el mismo no produjo un daño en su salud, pero debe tener presente que algunas lesiones (aunque usted no sienta dolor inicialmente o no resulten visibles ) se manifiestan varios días después del siniestro. Si usted deja pasar tiempo sin recibir atención médica, únicamente logrará que la compañía de seguros disminuya su indemnización al reclamar lesiones. tenga presente que al ser atendido siempre debe reclamar las constancias médicas y todos los estudios que le hayan realizado. (vea ¿Cuánto se cobra por lesiones como la cervicalgia o esguince cervical?).
						Siempre recordamos a nuestros clientes, la importancia ante estos sucesos de contar con toda la información posible a su alcance. Es por ello, que recomendamos tomar los datos del transporte donde se produjo el accidente, de testigos y otras víctimas del siniestro y de cualquier otro vehículo involucrado. También resaltamos la importancia de tomar fotos en donde se pueda apreciar la zona en que cada vehículo sufrió daños.
						Por último, le recomendamos que no firme acuerdos directamente con la aseguradora. El negocio de las empresas de seguros es pagarle a usted lo menos posible. Es por eso que harán parecer justa la suma que le ofrecen, pero lo único que buscan es cerrar el tema por la mínima cantidad posible. 
						Cuando usted se asesora con nosotros debe saber que contamos con el conocimiento necesario para que la compañía de seguros asuma la responsabilidad del choque y le pague el máximo obtenible. Nuestro importante caudal de reclamos facilita imponer al seguro condiciones de negociación más favorables para usted. Tenga presente además que las compañias de seguro pagan por riesgo judicial. Es decir que cuando interviene un abogado, el seguro, ante la posibilidad de afrontar un juicio, termina pagandole más para evitar los costos del mismo.
						Recuerde que usted cuenta con dos años para iniciar el reclamo. No deje pasar el tiempo y reciba lo que le corresponde.";
					break;

				case "accidentesEnBicicleta":
					longDesc =
						@" Todo siniestro en bicicleta puede ser indemnizado. Circulando por la bicisenda o fuera de ella tenes prioridad. Inicia con nosotros tu reclamo por lesiones en ocasión de un choque. 
							Es importante remarcar, que en el caso de ser una compañía de seguros ante quien se presente el reclamo extrajudicial y/o judicial, de realizarlo con la representación de un abogado, usted siempre percibirá un monto indemnizatorio superior (vea ¿Cuánto se cobra de indemnización por un accidente de tránsito?).
							Si usted o algún familiar/ amigo ha sufrido un accidente con su vehículo ya sea por culpa de un tercero o compartida, usted posee el derecho de realizar el reclamo de una indemnización justa, a fin de resarcir los daños materiales, físicos y morales que pudiese haber padecido.
							Por esa razon usted
							 debe asesorarse con profesionales de su confianza que le brinden el mejor servicio al menor costo. Le garantizamos un trámite rápido y la mejor atención para gestionar su indemnización brindándole un seguimiento constante de la evolución de su caso. Tenga presente que no siempre es necesario ir a juicio para lograr el cobro de lo que le corresponde, es por eso que nuestros servicios se adaptan a las necesidades de nuestros clientes a través de un contacto permanente. 
							---Es posible que las lesiones sufridas en un accidente de tránsito no aparenten gravedad y no exista intervención médica en el lugar. En esos casos es fundamental que usted/ y sus acompañantes busquen atención médica inmediatamente después del accidente. Tal vez usted crea que el choque fue menor y que el mismo no produjo un daño en su salud, pero debe tener presente que algunas lesiones (aunque usted no sienta dolor inicialmente o no resulten visibles ) se manifiestan varios días después del siniestro. Si usted deja pasar tiempo sin recibir atención médica, únicamente logrará que la compañía de seguros disminuya su indemnización al reclamar lesiones. tenga presente que al ser atendido siempre debe reclamar las constancias médicas y todos los estudios que le hayan realizado. (vea ¿Cuánto se cobra por lesiones como la cervicalgia o esguince cervical?).
							Siempre recordamos a nuestros clientes, la importancia ante estos sucesos de contar con toda la información posible a su alcance. Es por ello, que recomendamos tomar los datos del transporte donde se produjo el accidente, de testigos y otras víctimas del siniestro y de cualquier otro vehículo involucrado. También resaltamos la importancia de tomar fotos en donde se pueda apreciar la zona en que cada vehículo sufrió daños.
							Por último, le recomendamos que no firme acuerdos directamente con la aseguradora. El negocio de las empresas de seguros es pagarle a usted lo menos posible. Es por eso que harán parecer justa la suma que le ofrecen, pero lo único que buscan es cerrar el tema por la mínima cantidad posible. 
							Cuando usted se asesora con nosotros debe saber que contamos con el conocimiento necesario para que la compañía de seguros asuma la responsabilidad del choque y que le pague el máximo obtenible. Nuestro importante caudal de reclamos facilita imponer al seguro condiciones de negociación más favorables para usted. Tenga presente además que las compañias de seguro pagan por riesgo judicial. Es decir que cuando interviene un abogado, el seguro, ante la posibilidad de afrontar un juicio, termina pagandole más para evitar los costos del mismo.
							Recuerde que usted cuenta con dos años para iniciar el reclamo. No deje pasar el tiempo y reciba lo que le corresponde.";
					break;
				case "accidentesComoAcompanantes":
					longDesc =
						@" Al momento de ocurrir un accidente, un pasajero nunca es culpable. Incluso aunque viaje en el vehículo del conductor que ocasionó el accidente. Es por esto que si usted sufrió un accidente como pasajero o acompañante, siempre se encuentra amparado por la ley y posee el derecho de realizar el reclamo de una indemnización justa, a fin de resarcir los daños materiales, físicos y morales que pudiese haber padecido.
						En general, los accidentados como acompañantes no presentan el reclamo para no generarle un problema al dueño del vehículo, a quien conocen y no desean perjudicar. Si este último posee su seguro al día, la compañía de seguros será la que responda, el dueño del vehículo no se verá perjudicado de ninguna forma.
						Tenga en cuenta que si usted tuvo lesiones a consecuencia del accidente, ser representado por el mismo abogado que el conductor del vehículo en el que viajaba, podría crear conflictos de intereses para el abogado. En general, los pasajeros lastimados en un accidente, tienen mejores resultados cuando son representados por su propio abogado.
						Es importante remarcar, que en el caso de ser una compañía de seguros ante quien se presente el reclamo extrajudicial y/o judicial, de realizarlo con la representación de un abogado, usted siempre recibirá un monto indemnizatorio superior (vea ¿Cuánto se cobra de indemnización por un accidente de tránsito?).
						Si usted o algún familiar/ amigo ha sufrido un accidente con su vehículo ya sea por culpa de un tercero o compartida, usted posee el derecho de realizar el reclamo de una indemnización justa, a fin de resarcir los daños materiales, físicos y morales que pudiese haber padecido.
						Por esa razon usted
						 debe asesorarse con profesionales de su confianza que le brinden el mejor servicio al menor costo. Le garantizamos un trámite rápido y la mejor atención para gestionar su indemnización brindándole un seguimiento constante de la evolución de su caso. Tenga presente que no siempre es necesario ir a juicio para lograr el cobro de lo que le corresponde, es por eso que nuestros servicios se adaptan a las necesidades de nuestros clientes a través de un contacto permanente. 
						---Es posible que las lesiones sufridas en un accidente de tránsito no aparenten gravedad y no exista intervención médica en el lugar. En esos casos es fundamental que usted/ y sus acompañantes busquen atención médica inmediatamente después del accidente. Tal vez usted crea que el choque fue menor y que el mismo no produjo un daño en su salud, pero debe tener presente que algunas lesiones (aunque usted no sienta dolor inicialmente o no resulten visibles ) se manifiestan varios días después del siniestro. Si usted deja pasar tiempo sin recibir atención médica, unicamente lograra que la compañia de seguros disminuya su indemnización al reclamar lesiones. tenga presente que al ser atendido siempre debe reclamar las constancias médicas y todos los estudios que le hayan realizado. (vea ¿Cuánto se cobra por lesiones como la cervicalgia o esguince cervical?).
						Siempre recordamos a nuestros clientes, la importancia ante estos sucesos de contar con toda la información posible a su alcance. Es por ello, que recomendamos tomar los datos del transporte donde se produjo el accidente, de testigos y otras víctimas del siniestro y de cualquier otro vehículo involucrado. También resaltamos la importancia de tomar fotos en donde se pueda apreciar la zona en que cada vehículo sufrió daños.
						Por último, le recomendamos que no firme acuerdos directamente con la aseguradora. El negocio de las empresas de seguros es pagarle a usted lo menos posible. Es por eso que harán parecer justa la suma que le ofrecen, pero lo único que buscan es cerrar el tema por la mínima cantidad posible. 
						Cuando usted se asesora con nosotros debe saber que contamos con el conocimiento necesario para que la compañía de seguros asuma la responsabilidad del choque y que le pague el máximo obtenible. Nuestro importante caudal de reclamos facilita imponer al seguro condiciones de negociación más favorables para usted. Tenga presente además que las compañías de seguro pagan por riesgo judicial. Es decir que cuando interviene un abogado, el seguro, ante la posibilidad de afrontar un juicio, termina pagándole más para evitar los costos del mismo.
						Recuerde que usted cuenta con dos años para iniciar el reclamo. No deje pasar el tiempo y reciba lo que le corresponde.";
					break;

				case "accidentesComoPeaton":
					longDesc =
						@"Si usted o algún familiar ha sufrido un accidente como peatón, cuente con nosotros para realizar las acciones legales correspondientes, a fin de realizar el reclamo de una indemnización justa.
						Es importante remarcar, que en el caso de ser una compañía de seguros ante quien se presente el reclamo extrajudicial y/o judicial, de realizarlo con la representación de un abogado, usted siempre recibirá un monto indemnizatorio superior (vea ¿Cuánto se cobra de indemnización por un accidente de tránsito?).
						Si usted o algún familiar/ amigo ha sufrido un accidente con su vehículo ya sea por culpa de un tercero o compartida, usted posee el derecho de realizar el reclamo de una indemnización justa, a fin de resarcir los daños materiales, físicos y morales que pudiese haber padecido.
						Por esa razon usted
						 debe asesorarse con profesionales de su confianza que le brinden el mejor servicio al menor costo. Le garantizamos un trámite rápido y la mejor atencion para gestionar su indemnización brindándole un seguimiento constante de la evolución de su caso. Tenga presente que no siempre es necesario ir a juicio para lograr el cobro de lo que le corresponde, es por eso que nuestros servicios se adaptan a las necesidades de nuestros clientes a través de un contacto permanente. 
						---Es posible que las lesiones sufridas en un accidente de tránsito no aparenten gravedad y no exista intervención médica en el lugar. En esos casos es fundamental que usted/ y sus acompañantes busquen atención médica inmediatamente después del accidente. Tal vez usted crea que el choque fue menor y que el mismo no produjo un daño en su salud, pero debe tener presente que algunas lesiones (aunque usted no sienta dolor inicialmente o no resulten visibles ) se manifiestan varios días después del siniestro. Si usted deja pasar tiempo sin recibir atención médica, únicamente logrará que la compañía de seguros disminuya su indemnización al reclamar lesiones. tenga presente que al ser atendido siempre debe reclamar las constancias médicas y todos los estudios que le hayan realizado. (vea ¿Cuánto se cobra por lesiones como la cervicalgia o esguince cervical?).
						Siempre recordamos a nuestros clientes, la importancia ante estos sucesos de contar con toda la información posible a su alcance. Es por ello, que recomendamos tomar los datos del transporte donde se produjo el accidente, de testigos y otras víctimas del siniestro y de cualquier otro vehículo involucrado. También resaltamos la importancia de tomar fotos en donde se pueda apreciar la zona en que cada vehículo sufrió daños.
						Por último, le recomendamos que no firme acuerdos directamente con la aseguradora. El negocio de las empresas de seguros es pagarle a usted lo menos posible. Es por eso que harán parecer justa la suma que le ofrecen, pero lo único que buscan es cerrar el tema por la mínima cantidad posible. 
						Cuando usted se asesora con nosotros debe saber que contamos con el conocimiento necesario para que la compañía de seguros asuma la responsabilidad del choque y que le pague el máximo obtenible. Nuestro importante caudal de reclamos facilita imponer al seguro condiciones de negociación más favorables para usted. Tenga presente además que las compañías de seguro pagan por riesgo judicial. Es decir que cuando interviene un abogado, el seguro, ante la posibilidad de afrontar un juicio, termina pagandole más para evitar los costos del mismo.
						Recuerde que usted cuenta con dos años para iniciar el reclamo. No deje pasar el tiempo y reciba lo que le corresponde.";
					break;

				case "choqueSinSeguro":
					longDesc =
						@"Falta descripcion";
					break;

				case "accidentesDeTrabajo":
					longDesc =
						@"Falta descripcion";
					break;
			}

			var model = new ServiceModel
			{
				LongDesc = longDesc,
				ServiceName = GetServiceName(service),
				ContactModel = new ContactModel()
			};
			return View(model);
		}

		private string GetServiceName(string service)
		{
			var ret = "";
			switch (service)
			{
				case "accidentesEnTransportePublico":
					ret = "ACCIDENTES EN TRANSPORTE PUBLICO";
					break;
			}
			return ret;
		}
	}
}
