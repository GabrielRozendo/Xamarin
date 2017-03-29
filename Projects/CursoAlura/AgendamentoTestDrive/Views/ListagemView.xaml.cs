using System.Collections.Generic;
using Xamarin.Forms;
using System.Net.Http;

namespace AgendamentoTestDrive
{
	public partial class ListagemView : ContentPage
	{
		public ListagemView()
		{
			InitializeComponent();
		}

		void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
		{
			var veiculo = (Veiculo)e.Item;

			//DisplayAlert("Test Drive", $"Você escolheu o veículo {veiculo.Nome} que tem o preço {veiculo.PrecoFormatado}", "Isso mesmo!");
			Navigation.PushAsync(new DetalheView(veiculo));
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			MessagingCenter.Subscribe<Veiculo>(this, "VeiculoSelecionado",
											   (msg) =>
												{
													Navigation.PushAsync(new DetalheView(msg));
												});
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			MessagingCenter.Unsubscribe<Veiculo>(this, "VeiculoSelecionado");
		}
	}
}