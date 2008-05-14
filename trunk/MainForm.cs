/*
 * Creado por SharpDevelop.
 * Usuario: Dario
 * Fecha: 12-05-2008
 * Hora: 10:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sicocam
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
			
		void Timer1Tick(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			sicocam.Principal MForm = new Principal();
			//MessageBox.Show("Redireccionando","Mensaje Interno");
			this.Visible = false;
			MForm.Mf=this;
			MForm.Show();
			this.Visible = false;
		}
	}
}
