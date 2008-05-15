/*
 * Created by SharpDevelop.
 * User: Dario
 * Date: 27-11-2006
 * Time: 20:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sicocam
{
	partial class AyuGen : System.Windows.Forms.Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.GrillaAyuda = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.GrillaAyuda)).BeginInit();
			this.SuspendLayout();
			// 
			// GrillaAyuda
			// 
			this.GrillaAyuda.AllowUserToAddRows = false;
			this.GrillaAyuda.AllowUserToDeleteRows = false;
			this.GrillaAyuda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.GrillaAyuda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(141)))), ((int)(((byte)(111)))));
			this.GrillaAyuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GrillaAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GrillaAyuda.Location = new System.Drawing.Point(0, 0);
			this.GrillaAyuda.Name = "GrillaAyuda";
			this.GrillaAyuda.ReadOnly = true;
			this.GrillaAyuda.RowTemplate.Height = 24;
			this.GrillaAyuda.RowTemplate.ReadOnly = true;
			this.GrillaAyuda.Size = new System.Drawing.Size(700, 230);
			this.GrillaAyuda.TabIndex = 1;
			this.GrillaAyuda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaAyudaCellClick);
			// 
			// AyuGen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 230);
			this.Controls.Add(this.GrillaAyuda);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AyuGen";
			this.Text = "Ayuda";
			this.Load += new System.EventHandler(this.AyuGenLoad);
			((System.ComponentModel.ISupportInitialize)(this.GrillaAyuda)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView GrillaAyuda;
	}
}
