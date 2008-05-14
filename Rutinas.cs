/*
 * Creado por SharpDevelop.
 * Usuario: Dario
 * Fecha: 13-05-2008
 * Hora: 15:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sicocam
{
	/// <summary>
	/// Description of Rutinas.
	/// </summary>
	public class Rutinas
	{
		private negocio neg = new negocio();			

		public string exSQL( string sSQL )
		{
			negocio neg2 = new negocio();
			string sSalida = "";
		   	MySqlDataReader reader = neg2.select(sSQL);
		   	if (reader.Read())
		   	{
		   		sSalida = reader[0].ToString();
		   	}
			try{
				reader.Close();
				reader  = null;
			}catch(System.NullReferenceException r){
				r.ToString();
			}
		   	neg2.cerrar();
		   	
		   	return( sSalida );
		}
		public void FillGridView(DataGridView DataView, string sSql){
			string query        = sSql;
			DataSet ds          = neg.byAdapter(query, "table");
			DataView.DataSource = ds;
			DataView.DataMember = "table";
			neg.cerrar();
		}
		public void FillGrid(DataGrid DataView, string sSql){
			string query        = sSql;
			DataSet ds          = neg.byAdapter(query, "table");
			DataView.DataSource = ds;
			DataView.DataMember = "table";
			neg.cerrar();
		}
	}
}
