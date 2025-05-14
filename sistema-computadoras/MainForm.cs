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
  	
  	private Button botonGuardar = new Button();
  	private Button botonMostrar = new Button();
  	
    public MainForm()
    {
    	FlowLayoutPanel panelMain = new FlowLayoutPanel();
    	panelMain.AutoSize = true;
    	panelMain.Controls.Add(form);
    	panelMain.FlowDirection = FlowDirection.TopDown;
    	Controls.Add(panelMain);
    	FlowLayoutPanel panelBotones = new FlowLayoutPanel();
    	
    	panelMain.Controls.Add(botonGuardar);
    	panelMain.Controls.Add(botonMostrar);
    }
  }
}
