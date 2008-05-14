/*
 * Creado por SharpDevelop.
 * Usuario: Dario
 * Fecha: 13-05-2008
 * Hora: 15:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace sicocam
{
	/// <summary>
	/// Description of Mantenedor.
	/// </summary>
	public partial class Mantenedor : Form
	{
		public sicocam.Principal PP;
		private string tablaactual = "";
		private bool chngstate     = false;
		private bool newstate      = false;

		public Mantenedor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MantenedorFormClosed(object sender, FormClosedEventArgs e)
		{
			PP.Enabled=true;
		}
		
		void LoadGrid(){
			dataGridView1.Enabled = false;
			string SQL = "Select * from ";
			Rutinas rut = new Rutinas();
			switch(comboBox1.Text){
				case "Clientes":
					SQL += "clientes";
					this.tablaactual="clientes";
					break;
				case "Obras":
					SQL += "obras";
					this.tablaactual="obras";
					break;
				case "Personal":
					SQL += "personal";
					this.tablaactual="personal";
					break;
				case "Camiones":
					SQL += "camiones";
					this.tablaactual="camiones";
					break;
				case "Pozos":
					SQL += "pozos";
					this.tablaactual="pozos";
					break;
			}
			rut.FillGridView(dataGridView1,SQL);
			dataGridView1.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			switch(comboBox1.Text){
				case "Clientes":
					toolStripStatusLabel1.Text="Maestro de Clientes";
					dataGridView1.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
					dataGridView1.Columns[4].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
					break;
				case "Obras":
					toolStripStatusLabel1.Text="Maestro de Obras";
					dataGridView1.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
					break;
				case "Personal":
					toolStripStatusLabel1.Text="Maestro de Personal";
					dataGridView1.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
					break;
				case "Camiones":
					toolStripStatusLabel1.Text="Maestro de Camiones";
					SQL += "camiones";
					break;
				case "Pozos":
					toolStripStatusLabel1.Text="Maestro de Pozos";
					dataGridView1.Columns[1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
					break;
			}
			dataGridView1.Columns[0].ReadOnly = true;
			dataGridView1.Refresh();
			dataGridView1.Enabled = true;
		}
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			dataGridView1.Columns.Clear();
			LoadGrid();
		}
		
		void MantenedorResize(object sender, EventArgs e)
		{
			dataGridView1.Width  = this.Width - 32;
			dataGridView1.Height = this.Height - 94;
			dataGridView1.Refresh();
		}
		
		void DataGridView1RowLeave(object sender, DataGridViewCellEventArgs e)
		{
		}
		
		
		void DataGridView1UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			Rutinas rut   = new Rutinas();
			string sql    = "";
			toolStripStatusLabel1.Text="Eliminando Información";
			switch(comboBox1.Text){
				case "Clientes":
					if (e.Row.Cells[0].Value.ToString()!=""){
						sql  = "Delete from clientes ";
						sql += "Where idClientes="+e.Row.Cells[0].Value.ToString();
					}
					break;
				case "Obras":
					if (e.Row.Cells[0].Value.ToString()!=""){
						sql  = "Delete from obras ";
						sql += "Where idObras="+e.Row.Cells[0].Value.ToString();
					}
					break;
				case "Personal":
					if (e.Row.Cells[0].Value.ToString()!=""){
						sql  = "Delete from personal ";
						sql += "Where idPersonal="+e.Row.Cells[0].Value.ToString();
					}
					break;
				case "Camiones":
					if (e.Row.Cells[0].Value.ToString()!=""){
						sql  = "Delete from camiones ";
						sql += "Where idCamiones="+e.Row.Cells[0].Value.ToString();
					}
					break;
				case "Pozos":
					if (e.Row.Cells[0].Value.ToString()!=""){
						sql  = "Delete from pozos ";
						sql += "Where idPozos="+e.Row.Cells[0].Value.ToString();
					}
					break;
			}
			rut.exSQL(sql);
			toolStripStatusLabel1.Text="";
			
		}
		
		void DataGridView1CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (dataGridView1.Enabled){
				this.chngstate = true;
				// ... Grabar informacion ... //
				//toolStripStatusLabel1.Text = e.RowIndex.ToString()+"::"+dataGridView1.Rows.Count.ToString();
				if(e.RowIndex>-1 && e.RowIndex < dataGridView1.Rows.Count && dataGridView1.Enabled && this.chngstate){
					Rutinas rut   = new Rutinas();
					string sql    = "";
					toolStripStatusLabel1.Text="Grabando información";
					switch(comboBox1.Text){
						case "Clientes":
							if (this.newstate){
								sql  = "Insert into clientes ";
								sql += "(idClientes, Rut, Nombre, Direccion, Giro) Values (";
								sql += "null, ";
								sql += "'"+dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()+"', ";
								sql += "'"+dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()+"', ";
								sql += "'"+dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()+"', ";
								sql += "'"+dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()+"' ";
								sql += ")";
							}else{
								sql  = "Update clientes set ";
								sql += "Rut = '"          +dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()+"', ";
								sql += "Nombre = '"       +dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()+"', ";
								sql += "Direccion = '"    +dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()+"', ";
								sql += "Giro = '"         +dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()+"' ";
								sql += "Where idClientes="+dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
							}
							break;
						case "Obras":
							if (this.newstate){
								sql  = "Insert into obras ";
								sql += "(idObras, idClientes, Nombre, Direccion) Values (";
								sql += "null, ";
								sql += "'"+dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()+"', ";
								sql += "'"+dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()+"', ";
								sql += "'"+dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()+"' ";
								sql += ")";
							}else{
								sql  = "Update obras set ";
								sql += "idClientes = " +dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()+", ";
								sql += "Nombre = '"    +dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()+"', ";
								sql += "Direccion = '" +dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()+"' ";
								sql += "Where idObras="+dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
							}
							break;
						case "Personal":
							if (this.newstate){
								sql  = "Insert into personal ";
								sql += "(idPersonal, Rut, Nombre) Values (";
								sql += "null, ";
								sql += "'"+dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()+"', ";
								sql += "'"+dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()+"' ";
								sql += ")";
							}else{
								sql  = "Update personal set ";
								sql += "Rut = '"          +dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()+"', ";
								sql += "Nombre = '"       +dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()+"' ";
								sql += "Where idPersonal="+dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
							}
							break;
						case "Camiones":
							if (this.newstate){
								sql  = "Insert into camiones ";
								sql += "(idCamiones, Patente) Values (";
								sql += "null, ";
								sql += "'"+dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()+"' ";
								sql += ")";
							}else{
								sql  = "Update camiones set ";
								sql += "Patente = '"       +dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()+"', ";
								sql += "Where idCamiones=" +dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
							}
							break;
						case "Pozos":
							if (this.newstate){
								sql  = "Insert into pozos ";
								sql += "(idPozos, Nombre, Direccion) Values (";
								sql += "null, ";
								sql += "'"+dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()+"', ";
								sql += "'"+dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()+"' ";
								sql += ")";
							}else{
								sql  = "Update pozos set ";
								sql += "Nombre = '"+dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()+"', ";
								sql += "Direccion = '"+dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()+"' ";
								sql += "Where idPozos="+dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
							}
							break;
					}
					rut.exSQL(sql);
					toolStripStatusLabel1.Text="";
					LoadGrid();
					dataGridView1.Focus();
					this.chngstate = false;
					this.newstate = false;
				}
			}
		}

		void DataGridView1RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			if (dataGridView1.Enabled){
				this.newstate = true;
				this.chngstate = true;
			}
		}
	}
}
