/*
 * Created by SharpDevelop.
 * User: User
 * Date: 20/5/2025
 * Time: 16:43
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
	/// <summary>
	/// Description of VentanaInfo.
	/// </summary>
	public class VentanaInfo : Form
	{
		private DataGridView vistaInfo;
		
		public VentanaInfo(InfoComputadora computadora)
		{
			crearGridView(computadora);
			Controls.Add(vistaInfo);
			ShowDialog();
		}
		
		private void crearGridView(InfoComputadora computadora)
		{
			vistaInfo = new DataGridView();
			vistaInfo.DataSource = computadora;
			vistaInfo.Dock = DockStyle.Fill;
			vistaInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;	
			List<InfoComputadora> source = new List<InfoComputadora>() {computadora};
			vistaInfo.DataSource = computadora;
		}
	}
}
