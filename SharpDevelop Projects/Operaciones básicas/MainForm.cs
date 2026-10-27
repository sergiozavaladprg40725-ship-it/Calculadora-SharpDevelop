/*
 * Created by SharpDevelop.
 * User: CC2_PC50
 * Date: 26/10/2026
 * Time: 07:23 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Operaciones_básicas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtPrimero.Text = "";
			txtSegundo.Text = "";
			lblRespuesta.Text = "";
		}
		
		void BtnSumaClick(object sender, EventArgs e)
		{
		    double lblPrimero, lblSegundo, suma;
			
		    lblPrimero = Convert.ToDouble(txtPrimero.Text);
		    lblSegundo = Convert.ToDouble(txtSegundo.Text);
		    
		    suma = lblPrimero + lblSegundo;
		    lblRespuesta.Text = Convert.ToString(suma);
		}
		
		void BtnMultiplicacionClick(object sender, EventArgs e)
		{
			
		    double lblPrimero, lblSegundo, multiplicar;
			
		    lblPrimero = Convert.ToDouble(txtPrimero.Text);
		    lblSegundo = Convert.ToDouble(txtSegundo.Text);
		    
		    multiplicar = lblPrimero * lblSegundo;
		    lblRespuesta.Text = Convert.ToString(multiplicar);
		}
		
		void BtnRestaClick(object sender, EventArgs e)
		{
			
		    double lblPrimero, lblSegundo, restar;
			
		    lblPrimero = Convert.ToDouble(txtPrimero.Text);
		    lblSegundo = Convert.ToDouble(txtSegundo.Text);
		    
		    restar = lblPrimero - lblSegundo;
		    lblRespuesta.Text = Convert.ToString(restar);
		}
		
		void BtnDividirClick(object sender, EventArgs e)
		{
			
		    double lblPrimero, lblSegundo, dividir;
			
		    lblPrimero = Convert.ToDouble(txtPrimero.Text);
		    lblSegundo = Convert.ToDouble(txtSegundo.Text);
		    
		    dividir = lblPrimero / lblSegundo;
		    lblRespuesta.Text = Convert.ToString(dividir);
		}
	}
}
