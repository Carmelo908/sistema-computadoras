using System;

public enum TiposComputadora{
	escritorio,
	laptop
}

namespace sistema_computadoras
{
	public class InfoComputadora
	{
		private readonly DateTime fechaIngreso;
		private readonly TiposComputadora tipoComputadora;
		public string estudianteAsignado;
		public string signos;
		public string estado;
		public string diagnostico = "";
		public bool reparado = false;
		
		public InfoComputadora(TiposComputadora tipo, string estudiante, 
		                       string signos, string diagnostico)
		{
			fechaIngreso = new DateTime();
			tipoComputadora = tipo;
			estudianteAsignado = estudiante;
			this.signos = signos;
			this.diagnostico = diagnostico;
		}
	}
}
