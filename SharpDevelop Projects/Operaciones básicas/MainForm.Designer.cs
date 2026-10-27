/*
 * Created by SharpDevelop.
 * User: CC2_PC50
 * Date: 26/10/2026
 * Time: 07:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Operaciones_básicas
{
	partial class MainForm
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
			this.lblPrimero = new System.Windows.Forms.Label();
			this.lblSegundo = new System.Windows.Forms.Label();
			this.btnSuma = new System.Windows.Forms.Button();
			this.btnResta = new System.Windows.Forms.Button();
			this.btnMultiplicacion = new System.Windows.Forms.Button();
			this.txtPrimero = new System.Windows.Forms.TextBox();
			this.txtSegundo = new System.Windows.Forms.TextBox();
			this.btnDividir = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.btnModulo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblPrimero
			// 
			this.lblPrimero.Location = new System.Drawing.Point(12, 9);
			this.lblPrimero.Name = "lblPrimero";
			this.lblPrimero.Size = new System.Drawing.Size(100, 23);
			this.lblPrimero.TabIndex = 0;
			this.lblPrimero.Text = "Primer num";
			// 
			// lblSegundo
			// 
			this.lblSegundo.Location = new System.Drawing.Point(12, 44);
			this.lblSegundo.Name = "lblSegundo";
			this.lblSegundo.Size = new System.Drawing.Size(100, 23);
			this.lblSegundo.TabIndex = 1;
			this.lblSegundo.Text = "Segundo num";
			// 
			// btnSuma
			// 
			this.btnSuma.Location = new System.Drawing.Point(12, 129);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(75, 23);
			this.btnSuma.TabIndex = 2;
			this.btnSuma.Text = "Suma";
			this.btnSuma.UseVisualStyleBackColor = true;
			this.btnSuma.Click += new System.EventHandler(this.BtnSumaClick);
			// 
			// btnResta
			// 
			this.btnResta.Location = new System.Drawing.Point(109, 129);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(75, 23);
			this.btnResta.TabIndex = 3;
			this.btnResta.Text = "Resta";
			this.btnResta.UseVisualStyleBackColor = true;
			this.btnResta.Click += new System.EventHandler(this.BtnRestaClick);
			// 
			// btnMultiplicacion
			// 
			this.btnMultiplicacion.Location = new System.Drawing.Point(12, 176);
			this.btnMultiplicacion.Name = "btnMultiplicacion";
			this.btnMultiplicacion.Size = new System.Drawing.Size(75, 23);
			this.btnMultiplicacion.TabIndex = 4;
			this.btnMultiplicacion.Text = "Multiplicar";
			this.btnMultiplicacion.UseVisualStyleBackColor = true;
			this.btnMultiplicacion.Click += new System.EventHandler(this.BtnMultiplicacionClick);
			// 
			// txtPrimero
			// 
			this.txtPrimero.Location = new System.Drawing.Point(109, 6);
			this.txtPrimero.Name = "txtPrimero";
			this.txtPrimero.Size = new System.Drawing.Size(134, 20);
			this.txtPrimero.TabIndex = 5;
			// 
			// txtSegundo
			// 
			this.txtSegundo.Location = new System.Drawing.Point(109, 41);
			this.txtSegundo.Name = "txtSegundo";
			this.txtSegundo.Size = new System.Drawing.Size(134, 20);
			this.txtSegundo.TabIndex = 6;
			// 
			// btnDividir
			// 
			this.btnDividir.Location = new System.Drawing.Point(109, 176);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(75, 23);
			this.btnDividir.TabIndex = 7;
			this.btnDividir.Text = "Dividir";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.BtnDividirClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(197, 226);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 8;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.Location = new System.Drawing.Point(12, 71);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(212, 42);
			this.lblRespuesta.TabIndex = 9;
			// 
			// btnModulo
			// 
			this.btnModulo.Location = new System.Drawing.Point(197, 129);
			this.btnModulo.Name = "btnModulo";
			this.btnModulo.Size = new System.Drawing.Size(75, 23);
			this.btnModulo.TabIndex = 10;
			this.btnModulo.Text = "Modulo";
			this.btnModulo.UseVisualStyleBackColor = true;
			this.btnModulo.Click += new System.EventHandler(this.BtnModuloClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnModulo);
			this.Controls.Add(this.lblRespuesta);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.txtSegundo);
			this.Controls.Add(this.txtPrimero);
			this.Controls.Add(this.btnMultiplicacion);
			this.Controls.Add(this.btnResta);
			this.Controls.Add(this.btnSuma);
			this.Controls.Add(this.lblSegundo);
			this.Controls.Add(this.lblPrimero);
			this.Name = "MainForm";
			this.Text = "Operaciones básicas";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnModulo;
		private System.Windows.Forms.Label lblRespuesta;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.TextBox txtSegundo;
		private System.Windows.Forms.TextBox txtPrimero;
		private System.Windows.Forms.Button btnMultiplicacion;
		private System.Windows.Forms.Button btnResta;
		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.Label lblSegundo;
		private System.Windows.Forms.Label lblPrimero;
	}
}
