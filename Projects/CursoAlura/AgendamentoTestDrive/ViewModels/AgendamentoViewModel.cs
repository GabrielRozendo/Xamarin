using System;
using System.Windows.Input;
using Xamarin.Forms;
namespace AgendamentoTestDrive
{
	public class AgendamentoViewModel
	{
		public AgendamentoViewModel(Veiculo veiculo)
		{
			this.Agendamento = new Agendamento();
			this.Agendamento.Veiculo = veiculo;
			AgendarCommand = new Command(() =>
			{
				MessagingCenter.Send<Agendamento>(this.Agendamento, "Agendamento");
			});
		}

		#region Propriedades
		public Agendamento Agendamento { get; set; }

		public Veiculo Veiculo
		{
			get { return Agendamento.Veiculo; }
			set { Agendamento.Veiculo = value; }
		}

		public string Nome
		{
			get { return Agendamento.Nome; }
			set { Agendamento.Nome = value; }
		}

		public string Fone
		{
			get { return Agendamento.Fone; }
			set { Agendamento.Fone = value; }
		}

		public string Email
		{
			get { return Agendamento.Email; }
			set { Agendamento.Email = value; }
		}

		public int Idade
		{
			get { return Agendamento.Idade; }
			set { Agendamento.Idade = value; }
		}

		public DateTime DataAgendamento
		{
			get { return Agendamento.DataAgendamento; }
			set { Agendamento.DataAgendamento = value; }
		}

		public TimeSpan HoraAgendamento
		{
			get { return Agendamento.HoraAgendamento; }
			set { Agendamento.HoraAgendamento = value; }
		}
		#endregion

		public ICommand AgendarCommand { get; set; }
	}
}
