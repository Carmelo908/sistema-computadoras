/*
 * Created by SharpDevelop.
 * User: User
 * Date: 7/5/2025
 * Time: 09:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using sistema_computadoras;

namespace sistema_computadoras
{
	public class FormComputadora : TableLayoutPanel
	{
		private RadioButton laptopRadio = new RadioButton();
		private RadioButton escritorioRadio = new RadioButton();
		private TextBox CampoEstudiante = new TextBox();
		private TextBox CampoSignos = new TextBox();
		private TextBox CampoEstado = new TextBox();
		
		private TiposComputadora tipoComputadora;
		
		public FormComputadora()
		{
			configurarLayout();
			crearRadios();
			crearCeldaTipo();
			crearTabla();
		}
		
		private void crearTabla()
		{
			Controls.Add(crearCeldaTipo(), 0, 0);
			Controls.Add(crearCeldaEstudiante(), 1, 0);
			Controls.Add(crearCeldaSignos(), 0, 1);
			Controls.Add(crearCeldaEstado(), 1, 1);
		}
		
		private void configurarLayout()
		{
			ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			RowStyles.Add(new RowStyle(SizeType.AutoSize));
			RowStyles.Add(new RowStyle(SizeType.AutoSize));
			RowStyles.Add(new RowStyle(SizeType.AutoSize));
			ColumnCount = 2;
			RowCount = 4;
			AutoSize = true;
			Padding = new Padding(10);
		}
		
		private void crearRadios()
		{
			escritorioRadio.Text = "Escritorio";
			escritorioRadio.Checked = true;
			laptopRadio.Text = "Laptop";
		}
		
		private Label crearEtiqueta(string texto)
		{
			Label result = new Label();
			result.AutoSize = true;
			result.Text = texto;
			result.Padding = new Padding(0, 10, 0, 10);
			return result;
		}
		
		private FlowLayoutPanel crearCelda()
		{
			FlowLayoutPanel celda = new FlowLayoutPanel();
			celda.FlowDirection = FlowDirection.TopDown;
			celda.AutoSize = true;
			return celda;
		}
		
		private FlowLayoutPanel crearCeldaTipo()
		{
			FlowLayoutPanel seleccionTipo = crearCelda();
			Label etiquetaTipo = crearEtiqueta("Tipo de computadora:");
			seleccionTipo.Controls.Add(etiquetaTipo);
			seleccionTipo.Controls.Add(escritorioRadio);
			seleccionTipo.Controls.Add(laptopRadio);
			return seleccionTipo;
		}
		
		private FlowLayoutPanel crearCeldaEstudiante()
		{
			FlowLayoutPanel celdaEstudiante = crearCelda();
			Label etiquetaEstudiante = crearEtiqueta("Estudiante a cargo:");
			CampoEstudiante.Width = 150;
			celdaEstudiante.Controls.Add(etiquetaEstudiante);
			celdaEstudiante.Controls.Add(CampoEstudiante);
			return celdaEstudiante;
		}
		
		private TextBox crearInputGrande()
		{
			TextBox result = new TextBox();
			result.Multiline = true;
			result.Width = 180;
			result.Height = 90;
			return result;
		}
		
		private FlowLayoutPanel crearCeldaSignos()
		{
			FlowLayoutPanel celdaSignos = crearCelda();
			Label etiquetaSignos = crearEtiqueta("Signos de falla:");
			celdaSignos.Controls.Add(etiquetaSignos);
			CampoSignos= crearInputGrande();
			celdaSignos.Controls.Add(CampoSignos);
			return celdaSignos;
		}
		
		private FlowLayoutPanel crearCeldaEstado()
		{
			FlowLayoutPanel celdaNotas = crearCelda();
			Label etiquetaNotas = crearEtiqueta("Estado e información relevante:");
			celdaNotas.Controls.Add(etiquetaNotas);
			CampoEstado = crearInputGrande();
			celdaNotas.Controls.Add(CampoEstado);
			return celdaNotas;
		}
	}
}
