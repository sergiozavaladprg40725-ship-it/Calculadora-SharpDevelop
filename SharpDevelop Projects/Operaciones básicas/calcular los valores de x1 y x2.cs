/*
 * Created by SharpDevelop.
 * User: CC2_PC50
 * Date: 27/10/2026
 * Time: 08:15 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Operaciones_básicas
{
	/// <summary>
	/// Description of calcular_los_valores_de_x1_y_x2.
	/// </summary>
	public partial class calcular_los_valores_de_x1_y_x2 : Form
	{
		public calcular_los_valores_de_x1_y_x2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularxClick(object sender, EventArgs e)
		{
			
		    double a = double.Parse(txtA.Text);
		    double b = double.Parse(txtB.Text);
		    double c = double.Parse(txtC.Text);
		    
		    double discriminante = (b * b) - (4 * a * c);
		    
		    if (a == 0)
		    {
		        lblResultado.Text = "Error: 'a' no puede ser 0 en una ecuación cuadrática.";
		    }
		    else if (discriminante < 0)
		    {
		        lblResultado.Text = "Resultado: Las raíces son imaginarias (no reales).";
		    }
		    else
		    {
		        double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
		        double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
		        
		        lblResultado.Text = "X1 = " + x1.ToString() + "\nX2 = " + x2.ToString();
		    }
		}
		
		void Calcular_los_valores_de_x1_y_x2Load(object sender, EventArgs e)
		{
			
		}
	}
}
