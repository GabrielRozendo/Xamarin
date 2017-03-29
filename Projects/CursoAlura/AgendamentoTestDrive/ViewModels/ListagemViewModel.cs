using System;
using System.Collections.Generic;

namespace AgendamentoTestDrive
{
	public class ListagemViewModel
	{
		public List<Veiculo> Veiculos { get; set; }

		public ListagemViewModel()
		{
			this.Veiculos = new ListagemVeiculos().Veiculos;
		}

	}
}
