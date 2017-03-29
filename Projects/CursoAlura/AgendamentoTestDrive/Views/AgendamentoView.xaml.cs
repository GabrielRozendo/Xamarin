using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AgendamentoTestDrive
{
	public partial class AgendamentoView : ContentPage
	{
		public AgendamentoViewModel ViewModel { get; set; }

		public AgendamentoView(Veiculo veiculo)
		{
			InitializeComponent();
			this.ViewModel = new AgendamentoViewModel(veiculo);
			this.BindingContext = ViewModel;
		}

		void Handle_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			int result;
			string cellIdade = ((EntryCell)sender).Text;
			if (string.IsNullOrEmpty(cellIdade))
				return;

			if (!int.TryParse(cellIdade, out result))
			{
				DisplayAlert("Seus dados", $"Idade inválida! Preencha com apenas números.{Environment.NewLine}{cellIdade} não é válido...", "Tentar novamente");

			}
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			MessagingCenter.Subscribe<Agendamento>(this, "Agendamento", (obj) =>
			{
				string mensagem =
								$"Nome: {ViewModel.Agendamento.Nome}{Environment.NewLine}" +
						 		$"Fone: {ViewModel.Agendamento.Fone}{Environment.NewLine}" +
								$"E-mail: {ViewModel.Agendamento.Email}{Environment.NewLine}" +
								$"Idade: {ViewModel.Agendamento.Idade}{Environment.NewLine}" +

								$"{Environment.NewLine}" +
								$"Data Agendamento: {ViewModel.Agendamento.DataAgendamento.ToString("dd/MM/yyyy")}{Environment.NewLine}" +
								$"Hora Agendamento: {ViewModel.Agendamento.HoraAgendamento.ToString(@"hh\:mm")}{Environment.NewLine}" +

								$"{Environment.NewLine}" +
								$"Veículo: {ViewModel.Agendamento.Veiculo.Nome}{Environment.NewLine}" +
								$"{ViewModel.Agendamento.Veiculo.PrecoTotalFormatado}";

				DisplayAlert("Agendamento", mensagem, "OK");
			});
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			MessagingCenter.Unsubscribe<Agendamento>(this, "Agendamento");
		}
	}
}
