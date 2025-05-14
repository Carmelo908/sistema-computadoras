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
		private TiposComputadora tipoComputadora;
		public string id;
		public string estudianteAsignado;
		public string signos;
		public string estado;
		public string diagnostico = "";
		public bool reparado = false;
		
		public InfoComputadora(TiposComputadora tipo, DateTime fechaIngreso, 
		                       string id, string estudiante, string signos, 
		                       string diagnostico)
		{
			this.fechaIngreso = fechaIngreso;
			this.id = id;
			this.tipoComputadora = tipo;
			this.estudianteAsignado = estudiante;
			this.signos = signos;
			this.diagnostico = diagnostico;
		}
	}
}
