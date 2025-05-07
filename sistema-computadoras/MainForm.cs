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
  	
    public MainForm()
    {
    	Controls.Add(form);
    }
  }
}
