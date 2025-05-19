using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using sistema_computadoras;

namespace Trimestre
{
	
 	public sealed partial class MainForm : Form
	{
  		private FormComputadora form = new FormComputadora();
  	
  		private Button botonGuardar = new Button { Text = "Guardar", Enabled = false };
  		private Button botonMostrar = new Button { Text = "Mostrar" };

    	public MainForm()
    	{
    		AutoSize = true;
    		this.FormBorderStyle = FormBorderStyle.FixedDialog;
    		Controls.Add(form);
    	}
	}
}