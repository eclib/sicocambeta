/*
 * Creado por SharpDevelop.
 * Creado por : Eduardo Llanquileo a.k.a. :: EcliB   ::
 * Adaptado por : Dario Diaz       a.k.a. :: inddiaz ::
 * Fecha: 13-05-2008
 * Hora: 15:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Data;
using MySql.Data.MySqlClient; 
using System.Windows.Forms;

namespace sicocam
{
	/// <summary>
	/// Description of negocio.
	/// </summary>
	public class negocio
	{
		MySqlConnection dbcon;
		MySqlCommand dbcmd;
		MySqlDataReader reader;
		string server="127.0.0.1";
		
		string db="sicocam";
		string user="JED";
		string pass="acceso";
		string port="3306";
		
		public negocio()
		{

		}
	
		public MySqlConnection conexion (string server, string db, string user, string pass, string port)
		{
			string connectionString = "Server="+server+";Database="+db+";User ID="+user+";Password="+pass+";port="+port+";";
			dbcon = new MySqlConnection(connectionString);
			
			try {
				dbcon.Open();
			}
			catch (MySqlException e) {
				MessageBox.Show("Error de conexion"+e, "Error ", 
           		MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return dbcon=null;
			}
			finally {

			}
			
			
			return dbcon;
			
		}
		
		public DataSet byAdapter(string Query, string daName)
		{
			MySqlConnection dbcon = conexion(server, db, user, pass, port);
			MySqlDataAdapter da = new MySqlDataAdapter(Query, dbcon);
			DataSet ds = new DataSet();
			da.Fill(ds, daName);	
			return (ds);
		}
		
		public MySqlDataReader select (string Query)
		{
			MySqlConnection dbcon = conexion(server, db, user, pass, port);
			if (dbcon!=null){
				dbcmd  = dbcon.CreateCommand();
				dbcmd.CommandText   = Query;
				reader  = dbcmd.ExecuteReader();
				return reader;
			}
			else
			{
				reader = null;
			}
			return reader;
		}
		
		public void insert (string Query)
		{
			MySqlConnection dbcon = conexion(server, db, user, pass, port);
			if (dbcon!=null){
				dbcmd  = dbcon.CreateCommand();
				dbcmd.CommandText   = Query;
				reader  = dbcmd.ExecuteReader();
				cerrar();
			}
		}
		
		public void cerrar()
		{
			
			try{
				reader.Close();
				reader  = null;
			}catch(System.NullReferenceException r){
				r.ToString();
			}
			try{
				dbcmd.Dispose();
				dbcmd   = null;
			}catch(System.NullReferenceException r){
				r.ToString();
			}
			try{
				dbcon.Dispose();
				dbcon.Close();
				dbcon   = null;
			}catch(System.NullReferenceException r){
				r.ToString();
			}
		}
		
		public void delete(string Query)
		{
			MySqlConnection dbcon = conexion(server, db, user, pass, port);
			if (dbcon!=null){
				dbcmd  = dbcon.CreateCommand();
				dbcmd.CommandText   = Query;
				reader  = dbcmd.ExecuteReader();
				cerrar();
			}
		}

		public void update(string Query)
		{
			MySqlConnection dbcon = conexion(server, db, user, pass, port);
			if (dbcon!=null){
				dbcmd  = dbcon.CreateCommand();
				dbcmd.CommandText   = Query;
				reader  = dbcmd.ExecuteReader();
				cerrar();
			}
		}
		
		
	}}
