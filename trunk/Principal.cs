/*
 * Creado por SharpDevelop.
 * Usuario: Dario
 * Fecha: 12-05-2008
 * Hora: 12:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace sicocam
{
	/// <summary>
	/// Description of Principal.
	/// </summary>
	public partial class Principal : Form
	{
		public sicocam.MainForm Mf;
		public Principal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PrincipalFormClosed(object sender, FormClosedEventArgs e)
		{
			
			Mf.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			sicocam.Digitación Dg = new Digitación();
			this.Enabled = false;
			Dg.PP = this;
			Dg.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			sicocam.Mantenedor Mt = new Mantenedor();
			this.Enabled = false;
			Mt.PP = this;
			Mt.Show();
			
		}
	}
}
