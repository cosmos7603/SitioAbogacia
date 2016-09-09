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
						@"Es importante remarcar, al iniciar un reclamo ante una compañía de seguros, que de realizarlo con la representación de un abogado especializado, usted siempre percibirá un monto indemnizatorio mayor (vea ¿Cuánto se cobra de indemnización por un accidente de tránsito?).
							Ahora bien, en el caso en que usted haya sufrido un accidente donde quien ocasionó el mismo sea un vehículo distinto del suyo usted también tiene derecho a reclamar su indemnización.
							A veces uno puede pensar que si no tenía cobertura (por ejemplo, porque olvidó pagar la cuota a tiempo) no puede iniciar un reclamo. Cabe destacar que este es un error bastante común entre la gente. Más aún cuando la persona va a consultar a la compañía del tercero sin asesoría y de allí lo derivan a su propio seguro a realizar la denuncia administrativa. Es decir, el seguro del tercero lo deriva a su propio seguro. Cuando usted llega a su seguro, lo vuelven a derivar al seguro del tercero y asi sucesivamente agotándolo hasta que usted finalmente se resigna y abandona el reclamo.
							Lo que usted debe hacer en estos casos es contactarnos rápidamente y obtener asi la solución que necesita para cobrar lo que le corresponde.
							Usted debe asesorarse siempre con profesionales de su confianza que le brinden el mejor servicio al menor costo. Nosotros le garantizamos un trámite rápido y la mejor atención para gestionar su indemnización brindándole un seguimiento constante de la evolución de su caso. Tenga presente que no siempre es necesario ir a juicio para lograr el cobro de lo que le corresponde, es por eso que nuestros servicios se adaptan a las necesidades de nuestros clientes a través de un contacto permanente. 
							---Es posible que las lesiones sufridas en un accidente de tránsito no aparenten gravedad y no exista intervención médica en el lugar. En esos casos es fundamental que usted/ y sus acompañantes busquen atención médica inmediatamente después del accidente. Tal vez usted crea que el choque fue menor y que el mismo no produjo un daño en su salud, pero debe tener presente que algunas lesiones (aunque usted no sienta dolor inicialmente o no resulten visibles ) se manifiestan varios días después del siniestro. Si usted deja pasar tiempo sin recibir atención médica, únicamente logrará que la compañía de seguros disminuya su indemnización al reclamar lesiones. tenga presente que al ser atendido siempre debe reclamar las constancias médicas y todos los estudios que le hayan realizado. (vea ¿Cuánto se cobra por lesiones como la cervicalgia o esguince cervical?).
							Siempre recordamos a nuestros clientes, la importancia ante estos sucesos de contar con toda la información posible a su alcance. Es por ello, que recomendamos tomar los datos del transporte donde se produjo el accidente, de testigos y otras víctimas del siniestro y de cualquier otro vehículo involucrado. También resaltamos la importancia de tomar fotos en donde se pueda apreciar la zona en que cada vehículo sufrió daños.
							Por último, le recomendamos que no firme acuerdos directamente con la aseguradora. El negocio de las empresas de seguros es pagarle a usted lo menos posible. Es por eso que harán parecer justa la suma que le ofrecen, pero lo único que buscan es cerrar el tema por la mínima cantidad posible. 
							Cuando usted se asesora con nosotros debe saber que contamos con el conocimiento necesario para que la compañía de seguros asuma la responsabilidad del choque y que le pague el máximo obtenible. Nuestro importante caudal de reclamos facilita imponer al seguro condiciones de negociación más favorables para usted. Tenga presente además que las compañías de seguro pagan por riesgo judicial. Es decir que cuando interviene un abogado, el seguro, ante la posibilidad de afrontar un juicio, termina pagándole más para evitar los costos del mismo.
							Recuerde que usted cuenta con dos años para iniciar el reclamo. No deje pasar el tiempo y reciba lo que le corresponde.";
					break;

				case "accidentesDeTrabajo":
					longDesc =
						@"Si Ud. es víctima de un accidente en su trabajo, de un accidente in itinere (camino al trabajo o de regreso a su casa desde el trabajo) o de una enfermedad profesional, lo primero que debe hacer es informar a su empleador. Será su empleador quien informe a la ART lo sucedido (aunque también puede hacerlo usted mismo informando directamente a su ART). El paso siguiente es pedirle una copia de la denuncia a su empleador.
						Una vez que usted reciba la atención médica necesaria en su ART debe solicitar a la misma su historia clinica.
						Durante este proceso le recordamos que siempre es fundamental asesorarse legalmente. Tenga presente que, asi como en el caso de los seguros automotores, el negocio de las ARTs es pagarle a usted lo menos posible. En gran parte de los casos, pese a existir accidentes gravísimos y pruebas contundentes de secuelas, las ARTs brindan una minima atencion medica y luego le dan el alta al paciente sin ningun tipo de incapacidad o con un porcentaje muy bajo.
						Si usted ya atravesó este proceso y no está de acuerdo con la incapacidad que le asignó su ART aún está a tiempo de asesorarse. 
						El procedimiento que siguen las ART es el de notificar el alta (con o sin incapacidad) por carta documento, informándole a usted que tiene la posibilidad de concurrir a Comisión Médica sin necesidad de abogado. Lamentablemente, este es un trámite administrativo que ha sido declarado inconstitucional por la propia Corte Suprema de Justicia. Ello debido a que no interviene un Juez que garantice sus derechos y encima lo alientan a concurrir sin un abogado de confianza que proteja sus intereses.
						Se aprovechan del desconocimiento de la gente y bajo la apariencia de brindarle otra instancia de reclamo, lo que buscan es legitimar un procedimiento que avale pagarle a la víctima lo menos posible.
						No se deje engañar, ante tales injusticias del sistema nosotros nos paramos del lado del trabajador a defender sus derechos.
						Le recordamos que el reclamo se realiza directamente a la ART. Su empleador no tiene relación alguna con el reclamo y la indemnización que reciba usted proviene únicamente de la ART. Al realizar el reclamo usted no perjudica de ningun modo a su patron ni pone en riesgo su trabajo.";
					break;


				case "accidentesInItinere":
					longDesc = @"Los accidentes in itinere (del latin “itinere”: “en curso”) se encuentran definidos en el artículo sexto de la La Ley de Riesgos del Trabajo (Ley 24.557) como: “todo acontecimiento súbito y violento ocurrido por el hecho o en ocasión del trabajo, o en el trayecto entre el domicilio del trabajador y el lugar de trabajo, siempre y cuando el damnificado no hubiere interrumpido o alterado dicho trayecto por causas ajenas al trabajo”.
					 Ejemplo 1: El trabajador, luego de salir de su casa y llegando al trabajo, sufre un robo con herida de arma blanca, con cortes en el brazo, ocurrido en el trayecto al trabajo.
					 Ejemplo 2: El trabajador, volviendo a su hogar al salir de su jornada, caminando por la vereda, pisa mal y cae con fractura de rodilla.
					Como se puede apreciar, es todo accidente sufrido por el trabajador en el trayecto entre el hogar y el trabajo, ya sea yendo o volviendo del mismo, siempre y cuando el damnificado no hubiere interrumpido o alterado dicho trayecto por causas ajenas al trabajo.
					En estos casos, la ART deberá brindar las prestaciones médicas y dinerarias hasta el alta médica o término legal, y si del accidente in itinere, han quedado secuelas tanto psíquicas como físicas en la salud del trabajador, éste tiene el derecho a ser indemnizado conforme la normativa vigente.

					Si Ud. es víctima de un accidente en su trabajo, de un accidente in itinere (camino al trabajo o de regreso a su casa desde el trabajo) o de una enfermedad profesional, lo primero que debe hacer es informar a su empleador. Será su empleador quien informe a la ART lo sucedido (aunque también puede hacerlo usted mismo informando directamente a su ART). El paso siguiente es pedirle una copia de la denuncia a su empleador.
					Una vez que usted reciba la atención médica necesaria en su ART debe solicitar a la misma su historia clinica.
					Durante este proceso le recordamos que siempre es fundamental asesorarse legalmente. Tenga presente que, asi como en el caso de los seguros automotores, el negocio de las ARTs es pagarle a usted lo menos posible. En gran parte de los casos, pese a existir accidentes gravísimos y pruebas contundentes de secuelas, las ARTs brindan una minima atencion medica y luego le dan el alta al paciente sin ningun tipo de incapacidad o con un porcentaje muy bajo.
					Si usted ya atravesó este proceso y no está de acuerdo con la incapacidad que le asignó su ART aún está a tiempo de asesorarse. 
					El procedimiento que siguen las ART es el de notificar el alta (con o sin incapacidad) por carta documento, informándole a usted que tiene la posibilidad de concurrir a Comisión Médica sin necesidad de abogado. Lamentablemente, este es un trámite administrativo que ha sido declarado inconstitucional por la propia Corte Suprema de Justicia. Ello debido a que no interviene un Juez que garantice sus derechos y encima lo alientan a concurrir sin un abogado de confianza que proteja sus intereses.
					Se aprovechan del desconocimiento de la gente y bajo la apariencia de brindarle otra instancia de reclamo, lo que buscan es legitimar un procedimiento que avale pagarle a la víctima lo menos posible.
					No se deje engañar, ante tales injusticias del sistema nosotros nos paramos del lado del trabajador a defender sus derechos.
					Le recordamos que el reclamo se realiza directamente a la ART. Su empleador no tiene relación alguna con el reclamo y la indemnización que reciba usted proviene únicamente de la ART. Al realizar el reclamo usted no perjudica de ningun modo a su patron ni pone en riesgo su trabajo.";
					break;


				case "enfermedadesProfesionales":
					longDesc = @"Las enfermedades profesionales son aquellas producidas por causa del trabajo, a aquellos trabajadores que prestan tareas expuestos a factores de riesgo, como ser: movimientos forzosos y repetitivos, ruidos en el ambiente de trabajo, manipulación de sustancias químicas e inhalación de gases, entre otros.
					La Ley de Riesgos del Trabajo (Ley 24.557) las define en su artículo sexto como “aquellas que se encuentran incluidas en el listado que elaborará y revisará el Poder Ejecutivo, conforme al procedimiento del artículo 40 apartado 3 de esta ley. El listado identificará agente de riesgo, cuadros clínicos, exposición y actividades en capacidad de determinar la enfermedad profesional.”
					 Ejemplo 1: El trabajador, mecánico industrial, expuesto a altos niveles sonoros en el puesto de trabajo, padece hipoacusia bilateral.
					 Ejemplo 2: El trabajador, operario de máquina, expuesto a movimientos repetitivos del hombro derecho, padece tendinitis del hombro.
					 Ejemplo 3: El trabajador, docente de escuela, expuesto a la sobrecarga del uso de la voz, padece disfonía persistente
					En estos casos, la ART deberá brindar las prestaciones médicas y dinerarias hasta el alta médica o plazo legal, y si de la enfermedad profesional, han quedado secuelas tanto psíquicas como físicas en la salud del trabajador, éste tiene el derecho a ser indemnizado conforme la normativa vigente.

					Si Ud. es víctima de un accidente en su trabajo, de un accidente in itinere (camino al trabajo o de regreso a su casa desde el trabajo) o de una enfermedad profesional, lo primero que debe hacer es informar a su empleador. Será su empleador quien informe a la ART lo sucedido (aunque también puede hacerlo usted mismo informando directamente a su ART). El paso siguiente es pedirle una copia de la denuncia a su empleador.
					Una vez que usted reciba la atención médica necesaria en su ART debe solicitar a la misma su historia clinica.
					Durante este proceso le recordamos que siempre es fundamental asesorarse legalmente. Tenga presente que, asi como en el caso de los seguros automotores, el negocio de las ARTs es pagarle a usted lo menos posible. En gran parte de los casos, pese a existir accidentes gravísimos y pruebas contundentes de secuelas, las ARTs brindan una minima atencion medica y luego le dan el alta al paciente sin ningun tipo de incapacidad o con un porcentaje muy bajo.
					Si usted ya atravesó este proceso y no está de acuerdo con la incapacidad que le asignó su ART aún está a tiempo de asesorarse. 
					El procedimiento que siguen las ART es el de notificar el alta (con o sin incapacidad) por carta documento, informándole a usted que tiene la posibilidad de concurrir a Comisión Médica sin necesidad de abogado. Lamentablemente, este es un trámite administrativo que ha sido declarado inconstitucional por la propia Corte Suprema de Justicia. Ello debido a que no interviene un Juez que garantice sus derechos y encima lo alientan a concurrir sin un abogado de confianza que proteja sus intereses.
					Se aprovechan del desconocimiento de la gente y bajo la apariencia de brindarle otra instancia de reclamo, lo que buscan es legitimar un procedimiento que avale pagarle a la víctima lo menos posible.
					No se deje engañar, ante tales injusticias del sistema nosotros nos paramos del lado del trabajador a defender sus derechos.
					Le recordamos que el reclamo se realiza directamente a la ART. Su empleador no tiene relación alguna con el reclamo y la indemnización que reciba usted proviene únicamente de la ART. Al realizar el reclamo usted no perjudica de ningun modo a su patron ni pone en riesgo su trabajo.";
					break;

				case "destruccionTotal":
					longDesc = @"Si usted o algún familiar/ amigo ha sido víctima de un accidente en el cual su vehículo sufrió una destrucción total, debe asesorarse con profesionales de su confianza que le brinden el mejor servicio al menor costo. Le garantizamos un trámite rápido y la mejor atención para gestionar su indemnización brindándole un seguimiento constante de la evolución de su caso. Tenga presente que no siempre es necesario ir a juicio para lograr el cobro de lo que le corresponde, es por eso que nuestros servicios se adaptan a las necesidades de nuestros clientes a través de un contacto permanente. 
					Las compañías de seguros, tienen una doble manera de medir si un vehículo se encuentra destruido de forma total o no.
					Cláusula 80%
					Quienes tengan contratada una cobertura de destrucción total al 80%, deben saber que se considerará al automóvil como destruido por completo, si el costo de reparar el daño sufrido es superior al 80% del valor de la suma asegurada (el monto que figura en la póliza al momento del accidente).
					Cláusula 20%
					Cuando tengamos un automóvil asegurado con destrucción total al 20%, debemos saber que, en caso de siniestro, se sumará el valor de los restos. Si su valor no supera el 20% de la suma asegurada o de mercado, se considera que existe destrucción total.
					Por qué es importante saber esto? Porque cuando existe destrucción total, en vez de reclamarle al seguro del tercero se reclama al propio seguro, quien deberá indemnizarlo por el valor total de su vehículo.
					El problema se presenta cuando usted plantea a su seguro la existencia de destrucción total y el mismo no se quiere hacerse cargo de la indemnización. En todos los casos, la controversia gira alrededor de cual es el porcentaje (%) de destrucción que el seguro reconoce. Este siempre será inferior al 80% necesario para que usted cobre en su seguro desligandose asi del tema y derivándolo al seguro del tercero. Los casos más graves se presentan cuando usted tuvo la responsabilidad del choque, dado que, de ser asi, el seguro del tercero tampoco cubre los daños sufridos por su vehículo.
					Para definirlo con mayor claridad, aunque usted haya tenido la responsabilidad del choque, si existe destrucción total de su vehículo, su seguro debe cubrirle el valor total del coche.
					Cuando usted se asesora con nosotros debe saber que contamos con el conocimiento necesario para que la compañía de seguros asuma la responsabilidad y que le pague el máximo obtenible. Nuestro importante caudal de reclamos facilita imponer al seguro condiciones de negociación más favorables para usted. Tenga presente además que las compañías de seguro pagan por riesgo judicial. Es decir que cuando interviene un abogado, el seguro, ante la posibilidad de afrontar un juicio termina pagándole a usted más para evitar los costos del mismo.
					Recuerde que usted cuenta con dos años para iniciar el reclamo. No deje pasar el tiempo y reciba lo que le corresponde.
					¿Que es una Cláusula de Destrucción Total 80% – 20%?
					Las compañías, tienen una doble forma de medir si un vehículo se encuentra destruido de forma total o no.
					Cláusula 80%
					Para los que tengan contratada una cobertura de destrucción total al 80%, significa que, se considerará al automóvil como destruido por completo si el costo de arreglar el daño sufrido es superior al 80% del valor de la suma asegurada (el monto que figura en la póliza) o de mercado.
					Cláusula 20%
					En este caso, cuando tengamos un automóvil asegurado con destrucción total al 20%, debemos saber que, en caso de siniestro, se sumará el valor de los restos. Si su cotización no supera el 20% de la suma asegurada o de mercado, es considerado como destrucción total.
					¿Qué cláusula conviene?
					La cláusula del 80% es la más conveniente. Un motor en medianas condiciones ya es suficientemente caro como para superar el 30% del valor asegurado. Lo mismo sucede 
					al comprar repuestos, que siempre son caros, llegando fácilmente a importantes sumas ante una reparación.

					Conclusiones
					Debemos siempre leer bien la póliza, para evitar conflictos posteriores. Actualmente, la mayor parte de las aseguradoras ofrecen la cláusula del 80% para todas sus pólizas, mientras que la cláusula del 20% la ofrecen como complemento en las pólizas contra todo riesgo.";
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
				case "accidentesEnAuto":
					ret = "ACCIDENTES EN AUTO";
					break;
				case "accidentesEnMoto":
					ret = "ACCIDENTES EN MOTO";
					break;
				case "accidentesEnBicicleta":
					ret = "ACCIDENTES EN BICICLETA";
					break;
				case "accidentesComoAcompanantes":
					ret = "ACCIDENTES COMO ACOMPAÑANTE";
					break;
				case "accidentesComoPeaton":
					ret = "ACCIDENTES COMO PEATON";
					break;
				case "choqueSinSeguro":
					ret = "CHOCÓ Y NO TENÍA PAGO SU SEGURO";
					break;
				case "destruccionTotal":
					ret = "DESTRUCCIÓN TOTAL";
					break;
				case "accidentesDeTrabajo":
					ret = "ACCIDENTES EN OCASIÓN DEL TRABAJO";
					break;
				case "accidentesInItinere":
					ret = "ACCIDENTES IN ITINERE (CAMINO AL TRABAJO, O DE REGRESO A CASA)";
					break;

				case "enfermedadesProfesionales":
					ret = "ENFERMEDADES PROFESIONALES";
					break;
			}
			return ret;
		}
	}
}
