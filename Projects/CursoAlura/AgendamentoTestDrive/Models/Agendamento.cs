using System;
namespace AgendamentoTestDrive
{
	public class Agendamento
	{
		public Veiculo Veiculo { get; set; }

		public string Nome { get; set; }
		public string Fone { get; set; }
		public string Email { get; set; }
		public int Idade { get; set; }

		public DateTime DataAgendamento { get; set; } = DateTime.Today.AddDays(1);

		public TimeSpan HoraAgendamento { get; set; } = new TimeSpan(8, 0, 0);
	}
}
