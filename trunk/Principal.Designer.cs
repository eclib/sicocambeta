/*
 * Creado por SharpDevelop.
 * Usuario: Dario
 * Fecha: 12-05-2008
 * Hora: 12:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace sicocam
{
	partial class Principal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(56, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 152);
			this.button1.TabIndex = 0;
			this.button1.Text = "DIGITACIÓN";
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(394, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(152, 152);
			this.button2.TabIndex = 1;
			this.button2.Text = "INFORMES";
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.AccessibleDescription = "OpenTec";
			this.pictureBox1.AccessibleName = "OpenTec";
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(356, 471);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(394, 471);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "OpenTec (r)  - 2008";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button3
			// 
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(714, 309);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(152, 152);
			this.button3.TabIndex = 4;
			this.button3.Text = "MAESTROS";
			this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(897, 139);
			this.label2.TabIndex = 5;
			this.label2.Text = "SICOCAM";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(394, 309);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(152, 152);
			this.button4.TabIndex = 6;
			this.button4.Text = "Disponible";
			this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(56, 309);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(152, 152);
			this.button5.TabIndex = 7;
			this.button5.Text = "Disponible";
			this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(714, 12);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(152, 152);
			this.button6.TabIndex = 8;
			this.button6.Text = "Disponible";
			this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button6.UseVisualStyleBackColor = true;
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(921, 503);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Principal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SICOCAM";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrincipalFormClosed);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}
