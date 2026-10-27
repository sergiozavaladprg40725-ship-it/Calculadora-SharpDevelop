/*
 * Created by SharpDevelop.
 * User: CC2_PC50
 * Date: 27/10/2026
 * Time: 08:15 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Operaciones_básicas
{
	partial class calcular_los_valores_de_x1_y_x2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calcular_los_valores_de_x1_y_x2));
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.lblA = new System.Windows.Forms.Label();
			this.lblB = new System.Windows.Forms.Label();
			this.lblC = new System.Windows.Forms.Label();
			this.btnCalcularx = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(141, 12);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(145, 20);
			this.txtA.TabIndex = 0;
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(141, 52);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(145, 20);
			this.txtB.TabIndex = 1;
			// 
			// txtC
			// 
			this.txtC.Location = new System.Drawing.Point(141, 94);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(145, 20);
			this.txtC.TabIndex = 2;
			// 
			// lblA
			// 
			this.lblA.BackColor = System.Drawing.Color.Transparent;
			this.lblA.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA.ForeColor = System.Drawing.Color.White;
			this.lblA.Location = new System.Drawing.Point(25, 15);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(100, 23);
			this.lblA.TabIndex = 3;
			this.lblA.Text = "Valor de A:";
			// 
			// lblB
			// 
			this.lblB.BackColor = System.Drawing.Color.Transparent;
			this.lblB.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblB.ForeColor = System.Drawing.Color.White;
			this.lblB.Location = new System.Drawing.Point(25, 55);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(100, 23);
			this.lblB.TabIndex = 4;
			this.lblB.Text = "Valor de B:";
			// 
			// lblC
			// 
			this.lblC.BackColor = System.Drawing.Color.Transparent;
			this.lblC.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblC.ForeColor = System.Drawing.Color.White;
			this.lblC.Location = new System.Drawing.Point(25, 97);
			this.lblC.Name = "lblC";
			this.lblC.Size = new System.Drawing.Size(100, 23);
			this.lblC.TabIndex = 5;
			this.lblC.Text = "Valor de C:";
			// 
			// btnCalcularx
			// 
			this.btnCalcularx.BackColor = System.Drawing.Color.Transparent;
			this.btnCalcularx.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalcularx.BackgroundImage")));
			this.btnCalcularx.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcularx.ForeColor = System.Drawing.Color.White;
			this.btnCalcularx.Location = new System.Drawing.Point(82, 218);
			this.btnCalcularx.Name = "btnCalcularx";
			this.btnCalcularx.Size = new System.Drawing.Size(148, 65);
			this.btnCalcularx.TabIndex = 6;
			this.btnCalcularx.Text = "Calcular";
			this.btnCalcularx.UseVisualStyleBackColor = false;
			this.btnCalcularx.Click += new System.EventHandler(this.BtnCalcularxClick);
			// 
			// lblResultado
			// 
			this.lblResultado.BackColor = System.Drawing.Color.Transparent;
			this.lblResultado.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.White;
			this.lblResultado.Location = new System.Drawing.Point(27, 127);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(259, 64);
			this.lblResultado.TabIndex = 7;
			// 
			// calcular_los_valores_de_x1_y_x2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(309, 295);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnCalcularx);
			this.Controls.Add(this.lblC);
			this.Controls.Add(this.lblB);
			this.Controls.Add(this.lblA);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Name = "calcular_los_valores_de_x1_y_x2";
			this.Text = "calcular_los_valores_de_x1_y_x2";
			this.Load += new System.EventHandler(this.Calcular_los_valores_de_x1_y_x2Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnCalcularx;
		private System.Windows.Forms.Label lblC;
		private System.Windows.Forms.Label lblB;
		private System.Windows.Forms.Label lblA;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtA;
	}
}
