/*
 * Created by SharpDevelop.
 * User: Dario
 * Date: 27-11-2006
 * Time: 20:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace sicocam
{
	/// <summary>
	/// Description of AyuGen.
	/// </summary>
	public partial class AyuGen
	{
		private Queue org = new Queue();
		private Queue des = new Queue();
		
		private string SQL;

		public AyuGen(Queue Origen, Queue Destino, string sSQL)
		{
			this.org=Origen;
			this.des=Destino;
			this.SQL=sSQL;
						
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public AyuGen(string sSQL)
		{
			this.SQL=sSQL;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		void AyuGenLoad(object sender, System.EventArgs e)
		{
			Rutinas rut = new Rutinas();
			rut.FillGridView(GrillaAyuda,this.SQL);
		}

		public void AddDestino( TextBox D1)
		{
			this.des.Enqueue(D1);
		}
		public void AddOrigen( string O1)
		{
			this.org.Enqueue(O1);
		}
		
		void GrillaAyudaCellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			
			int Fila    = e.RowIndex;
			if(Fila==-1)
			{
				return;
			}
			else
			{
				foreach(string origen in this.org)
				{
						TextBox destino = (TextBox)this.des.Dequeue();
						destino.Text = GrillaAyuda.Rows[Fila].Cells[origen].Value.ToString();
				}
				this.Close();
			}
		}
	}
}
