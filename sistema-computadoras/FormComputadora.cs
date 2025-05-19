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
	public class ItemAula
	{
		public Aulas id { get; set; }
    	public string nombre { get; set; }

    	public override string ToString() { return nombre; }
	}
	
	public class FormComputadora : TableLayoutPanel
	{
		protected RadioButton laptopRadio = new RadioButton();
		protected RadioButton escritorioRadio = new RadioButton();
		protected TextBox campoEstudiante = new TextBox();
		protected ComboBox campoAula = new ComboBox();
		protected NumericUpDown campoNumero = new NumericUpDown();
		protected TextBox campoSignos = new TextBox();
		protected TextBox campoEstado = new TextBox();
		protected TextBox campoDiagnostico = new TextBox();
		protected DateTimePicker campoIngreso = new DateTimePicker();
		protected DateTimePicker campoFechaReparacion = new DateTimePicker();
		protected CheckBox checkboxReparado = new CheckBox();
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
			Controls.Add(crearCeldaReparacion(), 1, 0);
			
			Controls.Add(crearCeldaSignos(), 0, 1);
			Controls.Add(crearCeldaEstado(), 1, 1);
			
			Controls.Add(crearCeldaIngreso(), 0, 2);
			Controls.Add(crearCeldaEstudiante(), 1, 2);
			
			Controls.Add(crearCeldaDiagnostico(), 0, 3);
			Controls.Add(crearCeldaAulaNumero(), 1, 3);
			
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
		
		protected void crearComboAulas()
		{
			campoAula.Items.Add(new ItemAula { id = Aulas.aula6, nombre = "Aula 6"});
			campoAula.Items.Add(new ItemAula { id = Aulas.aula14, nombre = "Aula 14"});
			campoAula.Items.Add(new ItemAula { id = Aulas.aula15, nombre = "Aula 15"});
			campoAula.Items.Add(new ItemAula { id = Aulas.aula16, nombre = "Aula 16" });
			campoAula.Items.Add(new ItemAula { id = Aulas.biblioteca, nombre = "Biblioteca"});
			campoAula.Items.Add(new ItemAula { id = Aulas.administracion, nombre = "Administración"});
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
		
		protected FlowLayoutPanel crearCeldaEstudiante()
		{
			campoEstudiante.Width = 150;
			FlowLayoutPanel celdaEstudiante = crearCelda();
			Label etiquetaEstudiante = crearEtiqueta("Estudiante o docente a cargo:");
			Label etiquetaID = crearEtiqueta("Aula y número del equipo:");
			celdaEstudiante.Controls.Add(etiquetaEstudiante);
			celdaEstudiante.Controls.Add(campoEstudiante);
			return celdaEstudiante;
		}
		
		protected TextBox crearInputGrande()
		{
			TextBox result = new TextBox();
			result.Multiline = true;
			result.Width = 180;
			result.Height = 75;
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
		
		protected FlowLayoutPanel crearCeldaDiagnostico()
		{
			FlowLayoutPanel celdaDiagnostico = crearCelda();
			Label etiquetaDiagnostico = crearEtiqueta("Diagnostico:");
			celdaDiagnostico.Controls.Add(etiquetaDiagnostico);
			campoDiagnostico = crearInputGrande();
			celdaDiagnostico.Controls.Add(campoDiagnostico);
			return celdaDiagnostico;
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

		protected void clickCheckReparado(object sender, EventArgs e)
		{
			campoFechaReparacion.Enabled = checkboxReparado.Checked;
		}

		protected FlowLayoutPanel crearCeldaReparacion()
		{
			campoFechaReparacion.Width = 150;
			checkboxReparado.Text = "Está reparado";
			FlowLayoutPanel celdaReparacion = crearCelda();
			celdaReparacion.Controls.Add(checkboxReparado);
			Label etiquetaFechaReparacion = crearEtiqueta("Fecha de reparación: ");
			celdaReparacion.Controls.Add(etiquetaFechaReparacion);
			celdaReparacion.Controls.Add(campoFechaReparacion);
			campoFechaReparacion.Enabled = false;
			checkboxReparado.Click += clickCheckReparado;
			return celdaReparacion;
		}
		
		protected FlowLayoutPanel crearCeldaAulaNumero()
		{
			FlowLayoutPanel celdaAulaNumero = crearCelda();
			Label etiquetaAula = crearEtiqueta("Aula del equipo: ");
			celdaAulaNumero.Controls.Add(etiquetaAula);
			celdaAulaNumero.Controls.Add(campoAula);
			crearComboAulas();
			Label etiquetaNumero = crearEtiqueta("Número del equipo");
			celdaAulaNumero.Controls.Add(etiquetaNumero);
			campoNumero.Minimum = 1;
			campoNumero.Value = 1;
			campoNumero.Maximum = 30;
			celdaAulaNumero.Controls.Add(campoNumero);
			return celdaAulaNumero;
		}
		
		public InfoComputadora DevolverDatos()
		{
			InfoComputadora result = new InfoComputadora {
				fechaIngreso = campoIngreso.Value,
				fechaReparación = campoFechaReparacion.Value,
				tipoComputadora = escritorioRadio.Checked ? 
					TiposComputadora.escritorio : TiposComputadora.laptop,
				numeroComputadora = (int)campoNumero.Value,
				aulaComputadora = ((ItemAula)campoAula.SelectedValue).id,
				estudianteAsignado = campoEstudiante.Text,
				signos = campoSignos.Text,
				estado = campoEstado.Text,
				diagnostico = campoDiagnostico.Text,
				reparado = checkboxReparado.Checked,
			};
			return result;
		}
	}
}
