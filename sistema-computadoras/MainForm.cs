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
  	
  		private Button botonGuardar;
  		private Button botonMostrar;

    	public MainForm()
    	{
    		AutoSize = true;
    		FormBorderStyle = FormBorderStyle.FixedDialog;
    		FlowLayoutPanel mainLayout = crearMainLayout();
    		mainLayout.Controls.Add(form);
    		crearBotones();
    		TableLayoutPanel panelBotones = crearPanelBotones();
    		panelBotones.Controls.Add(botonGuardar, 0, 0);
    		panelBotones.Controls.Add(botonMostrar, 1, 0);
    		mainLayout.Controls.Add(panelBotones);
    		Controls.Add(mainLayout);
    	}
    	
    	private void mostrarInfo(object sender, EventArgs e)
		{
			new VentanaInfo(form.devolverDatos());
		}
    	
    	private FlowLayoutPanel crearMainLayout()
    	{
    		FlowLayoutPanel mainLayout = new FlowLayoutPanel();
    		mainLayout.FlowDirection = FlowDirection.TopDown;
    		mainLayout.AutoSize = true;
    		return mainLayout;
    	}
    	
    	private void crearBotones()
    	{
    		botonGuardar = new Button { Text = "Guardar", Enabled = false };
    		botonGuardar.Margin = new Padding(100, 0, 0, 0);
  			botonMostrar = new Button { Text = "Mostrar" };
    		botonMostrar.Margin = new Padding(0, 0, 100, 0);	
    		botonMostrar.Click += mostrarInfo;
    	}
    	
    	private TableLayoutPanel crearPanelBotones()
    	{
    		TableLayoutPanel panelBotones = new 
    			TableLayoutPanel {RowCount = 1, ColumnCount = 2, AutoSize = true};
    		panelBotones.AutoSize = true;
    		panelBotones.Dock = DockStyle.Fill;
    		panelBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
    		return panelBotones;
    	}
    	
    	
	}
}