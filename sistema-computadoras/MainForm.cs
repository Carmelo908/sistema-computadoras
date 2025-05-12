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
  	
  	private Button BotonGuardar = new Button();
  	private Button BotonMostrar = new Button();
  	
    public MainForm()
    {
    	FlowLayoutPanel
    	Controls.Add(form);
    	AutoSize = true;
    }
  }
}
