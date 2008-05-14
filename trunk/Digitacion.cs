/*
 * Creado por SharpDevelop.
 * Usuario: Dario
 * Fecha: 12-05-2008
 * Hora: 14:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
namespace sicocam
{
	/// <summary>
	/// Description of Digitacion.
	/// </summary>
	public partial class Digitacion : Form
	{
		public sicocam.Principal PP;
		private Queue org = new Queue();
		private Queue des = new Queue();
		private string SQL;
		
		public Digitacion()
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

		void DigitacionFormClosed(object sender, FormClosedEventArgs e)
		{
			PP.Enabled=true;
		}
	}
}
