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

		protected override void OnAppearing()
		{
			base.OnAppearing();
			MessagingCenter.Subscribe<Veiculo>(this, "Proximo", (msg) =>
			{
				Navigation.PushAsync(new AgendamentoView(msg));
			});
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			MessagingCenter.Unsubscribe<Veiculo>(this, "Proximo");
		}
	}
}
