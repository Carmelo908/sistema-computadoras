using System;

public enum TiposComputadora
{
	escritorio,
	laptop
}

public enum Aulas
{
	aula6,
	aula14,
	aula15,
	aula16,
	biblioteca,
	administracion
}

namespace sistema_computadoras
{
	public class InfoComputadora
	{
		public DateTime fechaIngreso { get; set; }
		public DateTime fechaReparación { get; set; }
		public TiposComputadora tipoComputadora { get; set; }
		public int numeroComputadora { get; set; }
		public Aulas aulaComputadora { get; set; }
		public string estudianteAsignado { get; set; }
		public string signos { get; set; }
		public string estado { get; set; }	
		public string diagnostico { get; set; }
		public bool reparado { get; set; }
	}
}
