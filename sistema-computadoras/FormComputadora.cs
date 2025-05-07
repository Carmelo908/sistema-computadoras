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

namespace sistema_computadoras
{
	public class FormComputadora : TableLayoutPanel
	{
		private RadioButton laptopRadio = new RadioButton();
		private RadioButton escriotorioRadio = new RadioButton();
		private TextBox CampoEstudiante = new TextBox();
		private TextBox CampoNotas = new TextBox();
		private TextBox CampoSignos = new TextBox();
		private TextBox CampoEstado = new TextBox();
		
		public FormComputadora()
		{
			ColumnCount = 2;
			RowCount = 3;
			
			FlowLayoutPanel seleccionTipo = new FlowLayoutPanel();
			seleccionTipo.FlowDirection = FlowDirection.TopDown;
			Label etiquetaTipo = new Label();
			etiquetaTipo.Text = "Seleccione el tipo de computadora";
			seleccionTipo.Controls.Add(etiquetaTipo);
			crearRadios();
			seleccionTipo.Controls.Add(laptopRadio);
			seleccionTipo.Controls.Add(escriotorioRadio);
			Controls.Add(seleccionTipo);
		}
		
		private void crearRadios()
		{
			laptopRadio.Text = "Laptop";
			escriotorioRadio.Text = "Computadora de escritorio";
		}
		
	}
}
