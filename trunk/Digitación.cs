/*
 * Creado por SharpDevelop.
 * Usuario: Dario
 * Fecha: 12-05-2008
 * Hora: 14:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificaci�n | Editar Encabezados Est�ndar
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
namespace sicocam
{
	/// <summary>
	/// Description of Digitaci�n.
	/// </summary>
	public partial class Digitaci�n : Form
	{
		public sicocam.Principal PP;
		private Queue org = new Queue();
		private Queue des = new Queue();
		private string SQL;
		
		public Digitaci�n()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			this.SQL="Select * from guias";
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void GenLoad(object sender, System.EventArgs e)
		{
			Rutinas rut = new Rutinas();
			rut.FillGridView(dataGridView1,this.SQL);
		}

		void Digitaci�nFormClosed(object sender, FormClosedEventArgs e)
		{
			PP.Enabled=true;
		}
	}
}
