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
		protected RadioButton laptopRadio = new RadioButton();
		protected RadioButton escritorioRadio = new RadioButton();
		protected TextBox campoEstudiante = new TextBox();
		protected TextBox campoIdentificacion = new TextBox();
		protected TextBox campoSignos = new TextBox();
		protected TextBox campoEstado = new TextBox();
		protected DateTimePicker campoIngreso = new DateTimePicker();
		
		protected TiposComputadora tipoComputadora;
		
		public FormComputadora()
		{
			configurarLayout();
			crearRadios();
			crearCeldaTipo();
			crearTabla();
		}
		
		protected void crearTabla()
		{
			Controls.Add(crearCeldaTipo(), 0, 0);
			Controls.Add(crearCeldaEstudianteID(), 1, 0);
			Controls.Add(crearCeldaSignos(), 0, 1);
			Controls.Add(crearCeldaEstado(), 1, 1);
			Controls.Add(crearCeldaIngreso(), 0, 2);
		}
		
		protected void configurarLayout()
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
		
		protected void crearRadios()
		{
			escritorioRadio.Text = "Escritorio";
			escritorioRadio.Checked = true;
			laptopRadio.Text = "Laptop";
		}
		
		protected Label crearEtiqueta(string texto)
		{
			Label result = new Label();
			result.AutoSize = true;
			result.Text = texto;
			result.Padding = new Padding(0, 10, 0, 10);
			return result;
		}
		
		protected FlowLayoutPanel crearCelda()
		{
			FlowLayoutPanel celda = new FlowLayoutPanel();
			celda.FlowDirection = FlowDirection.TopDown;
			celda.AutoSize = true;
			return celda;
		}
			
		protected FlowLayoutPanel crearCeldaTipo()
		{
			FlowLayoutPanel seleccionTipo = crearCelda();
			Label etiquetaTipo = crearEtiqueta("Tipo de computadora:");
			seleccionTipo.Controls.Add(etiquetaTipo);
			seleccionTipo.Controls.Add(escritorioRadio);
			seleccionTipo.Controls.Add(laptopRadio);
			return seleccionTipo;
		}
		
		protected FlowLayoutPanel crearCeldaEstudianteID()
		{
			campoEstudiante.Width = 150;
			FlowLayoutPanel celdaEstudiante = crearCelda();
			Label etiquetaEstudiante = crearEtiqueta("Estudiante a cargo:");
			Label etiquetaID = crearEtiqueta("Aula y número del equipo:");
			campoIdentificacion.Width = 150;
			celdaEstudiante.Controls.Add(etiquetaEstudiante);
			celdaEstudiante.Controls.Add(campoEstudiante);
			celdaEstudiante.Controls.Add(etiquetaID);
			celdaEstudiante.Controls.Add(campoIdentificacion);
			return celdaEstudiante;
		}
		
		protected TextBox crearInputGrande()
		{
			TextBox result = new TextBox();
			result.Multiline = true;
			result.Width = 180;
			result.Height = 90;
			return result;
		}
		
		protected FlowLayoutPanel crearCeldaSignos()
		{
			FlowLayoutPanel celdaSignos = crearCelda();
			Label etiquetaSignos = crearEtiqueta("Signos de falla:");
			celdaSignos.Controls.Add(etiquetaSignos);
			campoSignos= crearInputGrande();
			celdaSignos.Controls.Add(campoSignos);
			return celdaSignos;
		}
		
		protected FlowLayoutPanel crearCeldaEstado()
		{
			FlowLayoutPanel celdaEstado = crearCelda();
			Label etiquetaNotas = crearEtiqueta("Estado e información relevante:");
			celdaEstado.Controls.Add(etiquetaNotas);
			campoEstado = crearInputGrande();
			celdaEstado.Controls.Add(campoEstado);
			return celdaEstado;
		}
		
		protected FlowLayoutPanel crearCeldaIngreso()
		{
			campoIngreso.Width = 150;
			FlowLayoutPanel celdaIngreso = crearCelda();
			Label etiquetaIngreso = crearEtiqueta("Fecha de ingreso:");
			celdaIngreso.Controls.Add(etiquetaIngreso);
			celdaIngreso.Controls.Add(campoIngreso);
			return celdaIngreso;
		}
		
		public InfoComputadora DevolverDatos()
		{
			TiposComputadora tipo = escritorioRadio.Checked ? 
				TiposComputadora.escritorio : TiposComputadora.laptop;
			DateTime fechaIngreso = campoIngreso.Value;
			string id = campoIdentificacion.Text;
			string estudiante = campoEstudiante.Text;
			string signos = campoSignos.Text;
			string diagnostico = "";
			
			return new InfoComputadora(tipo, fechaIngreso, id, estudiante, 
			                           signos, diagnostico);
		}
	}
}
