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
		private float distanciaLejana;							// Distancia de la camara
		/// <summary>
		/// <para>Altura de la distancia de la camara</para>
		/// </summary>
		private float distanciaUp;								// Altura de la distancia de la camara
		/// <summary>
		/// <para>Smooth de la camara</para>
		/// </summary>
		private float smooth;									// Smooth de la camara
		/// <summary>
		/// <para>Objetivo de la camara</para>
		/// </summary>
		private Transform pivote;								// Objetivo de la camara
		/// <summary>
		/// <para>Posicion del objetivo</para>
		/// </summary>
		private Vector3 posicionTarget;                         // Posicion del objetivo
		#endregion

		#region Init
		/// <summary>
		/// <para>Iniciador de MCamara.</para>
		/// </summary>
		private void Start()// Iniciador de MCamara
		{
			// Obtener el pivote de la camara
			pivote = GameObject.FindWithTag("Player").transform;
		}
		#endregion
	}
}
