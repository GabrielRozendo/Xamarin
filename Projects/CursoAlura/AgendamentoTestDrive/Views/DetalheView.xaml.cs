using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Globalization;

namespace AgendamentoTestDrive
{
	public partial class DetalheView : ContentPage
	{
		public Veiculo Veiculo { get; set; }

		public DetalheView(Veiculo veiculo)
		{
			InitializeComponent();
			this.Veiculo = veiculo;
			this.BindingContext = new DetalheViewModel(veiculo);
		}

		void buttonProximo_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new AgendamentoView(this.Veiculo));
		}
	}
}
