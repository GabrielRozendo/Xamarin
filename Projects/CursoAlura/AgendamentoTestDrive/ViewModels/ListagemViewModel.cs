using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AgendamentoTestDrive
{
	public class ListagemViewModel
	{
		public List<Veiculo> Veiculos { get; set; }

		private Veiculo veiculoSelecionado;
		public Veiculo VeiculoSelecionado
		{
			get { return veiculoSelecionado; }
			set
			{
				veiculoSelecionado = value;
				if (value != null)
					MessagingCenter.Send(VeiculoSelecionado, "VeiculoSelecionado");
			}
		}

		public ListagemViewModel()
		{
			this.Veiculos = new ListagemVeiculos().Veiculos;
		}

	}
}
