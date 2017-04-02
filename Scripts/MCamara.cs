//                                  ┌∩┐(◣_◢)┌∩┐
//																				\\
// MCamara.cs (28/03/2017)														\\
// Autor: Antonio Mateo (Moon Antonio) 									        \\
// Descripcion:		Controlador de la camara									\\
// Fecha Mod:		28/03/2017													\\
// Ultima Mod:		Version inicial												\\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace Pendulum.Controller
{
	/// <summary>
	/// <para>Controlador de la camara</para>
	/// </summary>
	[AddComponentMenu("Pendulum/Controller/MCamara")]
	public class MCamara : MonoBehaviour 
	{
		#region Variables Privadas
		/// <summary>
		/// <para>Distancia de la camara</para>
		/// </summary>
		public float camDistancia = 5f;							// Distancia de la camara
		/// <summary>
		/// <para>Altura de la distancia de la camara</para>
		/// </summary>
		public float camAltura = 2f;							// Altura de la distancia de la camara
		/// <summary>
		/// <para>Smooth de la camara</para>
		/// </summary>
		public float smooth = 3f;								// Smooth de la camara
		/// <summary>
		/// <para>Objetivo de la camara</para>
		/// </summary>
		private Transform pivote;								// Objetivo de la camara
		/// <summary>
		/// <para>Posicion del objetivo</para>
		/// </summary>
		private Vector3 posicionCamara;							// Posicion del objetivo
		#endregion

		#region Init
		/// <summary>
		/// <para>Iniciador de MCamara.</para>
		/// </summary>
		private void Start()// Iniciador de MCamara
		{
			// Obtener el pivote de la camara
			pivote = GameObject.FindWithTag("Pivote").transform;
		}
		#endregion

		#region Actualizadores
		/// <summary>
		/// <para>Actualizacion.Cuando termina todo el calculo.</para>
		/// </summary>
		private void LateUpdate()// Actualizacion.Cuando termina todo el calculo
		{
			// Ajustar la posicion del objetivo
			posicionCamara = pivote.position + pivote.up * camAltura - pivote.forward * camDistancia;

			// Debug, muestra los rays para ver si todo esta correctamente
			Rays();

			// Crear la transicion de la actual posicion a la nueva con el retraso
			this.transform.position = Vector3.Lerp(transform.position, posicionCamara, Time.deltaTime * smooth);

			// Bloquear la camara
			this.transform.LookAt(pivote);
		}
		#endregion

		#region API
		/// <summary>
		/// <para>Obtener la posicion de la camara(Solo lectura).</para>
		/// </summary>
		/// <returns>Devuelve la posicion de la camara.</returns>
		public Vector3 GetPosicionCamara()// Obtener la posicion de la camara(Solo lectura)
		{
			return posicionCamara;
		}
		#endregion

		#region Ray
		/// <summary>
		/// <para>Muestra los rays mandados</para>
		/// </summary>
		private void Rays()// Muestra los rays mandados
		{
			// Ray del pivote de la camara
			Debug.DrawRay(pivote.position, pivote.up * camAltura, Color.green);

			// Ray desde la posicion del pivote hasta la posicion de la camara
			Debug.DrawRay(pivote.position, -1f * pivote.forward * camDistancia, Color.green);

			// Ray de la orientacion de la camara hasta el pivote
			Debug.DrawLine(pivote.position, posicionCamara, Color.magenta);
		}
		#endregion
	}
}
