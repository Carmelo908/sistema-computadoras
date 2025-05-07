using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

	
namespace Trimestre
{
  public static class GUIFactory
  {
    
    public static Button ButtonFactory(string text)
    {
      Button button = new Button();
      button.Text = text;
      return button;
    }

  }
	
  public sealed partial class MainForm : Form
  {
    public MainForm()
    {
      Initialize();
      Button button = GUIFactory.ButtonFactory("ALGOOOO");
      button.Location = new Point(10, 10);
      this.Controls.Add(button);
    }
		
    private void Initialize()
    {
      this.Text = "Formulario"; 
      this.Size = new Size(600, 400); 
      this.StartPosition = FormStartPosition.CenterScreen; 
      this.BackColor = Color.White;
    }
  }
}
